using System;
using System.Collections.Generic;
using System.Data;


namespace WpfApp2
{
    public class DataTableLog
    {
        public List<LogRecord> Log { get; set; }
        public DataTable Table { get; set; }
        public int Index { get; set; }
        public bool CanRedo { get; set; }
        public bool IsUndoOrRedo { get; set; }
        public LogRecord RowChange { get; set; }
        public void SetRowChange(DataRow rowChange)
        {
            this.RowChange = new LogRecord(rowChange.ItemArray, DataRowStatus.CHANGING, rowChange);
           
        }
        public DataTableLog(DataTable dt)
        {
            Index = -1;
            IsUndoOrRedo = false;
            Log = new List<LogRecord>();
            this.Table = dt;
            CanRedo = false;
            Table.TableNewRow += OnTableNewRow;
            Table.RowChanged += OnRowChanged;
            Table.RowChanging += OnRowChanging;
            Table.RowDeleting += OnRowDeleting;
        }

        //them mot row moi
        bool isNew = false;
        protected void OnTableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            isNew = true;
        }
        //mot row moi that su dduocwj them vao data table
        protected void OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Row.RowState == DataRowState.Detached) 
                return;
            if (!IsUndoOrRedo)
            {
                if (CanRedo)
                {
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                    CanRedo = false;
                }
               
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.ADD, e.Row);
                if (lrc.Equals(RowChange)) return;
                if (!isNew) lrc.Status = DataRowStatus.CHANGED;
                Log.Add(lrc);
                SetRowChange(e.Row);
                Index++;

            }
        }

        //mot row moi that su dduocwj them vao data table
        protected void OnRowChanging(object sender, DataRowChangeEventArgs e)
        {
            if (isNew) return;
            if (!IsUndoOrRedo)
            {
                if (CanRedo)
                {
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                    CanRedo = false;
                }
                LogRecord newlrc = new LogRecord(e.Row.ItemArray, DataRowStatus.CHANGING, e.Row);
                if (newlrc.Equals(RowChange))
                    return;
                if (RowChange != null)
                    Log.Add(RowChange);
                Index++;

            }
        }

        protected void OnRowDeleting(object sender, DataRowChangeEventArgs e)
        {
            if (!IsUndoOrRedo)
            {
                if (CanRedo)
                {
                    Log.RemoveRange(Index + 1, Log.Count - (Index + 1));
                    CanRedo = false;
                }
                LogRecord lrc = new LogRecord(e.Row.ItemArray, DataRowStatus.DELETE, e.Row.Table.NewRow());
                Log.Add(lrc);
                Index++;
            }
        }
        public void Undo()
        {
            IsUndoOrRedo = true;
            if (Index > Log.Count - 1) Index = Log.Count - 1;
            if (Index >= 0)
            {
                LogRecord rc = Log[Index];
                LogRecord l = rc;
                if (rc.Status == DataRowStatus.ADD)
                {
                    Table.Rows.Remove(rc.Row);
                    Index--;
                }
                else
                {
                    if (rc.Status == DataRowStatus.DELETE)
                    {

                        for (int i = 0; i < rc.RowItems.Length; i++)
                        {
                            rc.Row[i] = rc.RowItems[i];
                        }
                        Table.Rows.Add(rc.Row);
                        Index--;
                    }
                    else
                    {
                        if (l.Status == DataRowStatus.CHANGING)
                        {
                            l = Log[Index];
                            for (int i = 0; i < rc.RowItems.Length; i++)
                            {
                                l.Row[i] = l.RowItems[i];
                            }
                            Index--;
                        }
                        else
                        {
                            Index--;
                            Undo();
                        }

                    }

                }
                CanRedo = true;
            }
            IsUndoOrRedo = false;
        }
        public void Redo()
        {
            IsUndoOrRedo = true;

            if (Index < Log.Count - 1)
            {
                Index++;
                LogRecord rc = Log[Index];
                if (rc.Status == DataRowStatus.ADD)
                {
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                    Table.Rows.Add(rc.Row);

                }
                else if (rc.Status == DataRowStatus.DELETE)
                {
                    Table.Rows.Remove(rc.Row);
                }
                else if (rc.Status == DataRowStatus.CHANGED)
                {
                    rc = Log[Index];
                    for (int i = 0; i < rc.RowItems.Length; i++)
                    {
                        rc.Row[i] = rc.RowItems[i];
                    }
                }
                else
                {
                    Redo();
                }
            }
            else
            {
                CanRedo = false;
            }

            IsUndoOrRedo = false;
        }

    }
    public enum DataRowStatus
    {
        ADD, DELETE, CHANGING, CHANGED
    }
    public class LogRecord
    {
        public Object[] RowItems { get; set; }
        public DataRowStatus Status { get; set; }
        public DataRow Row { get; set; }
        public LogRecord()
        {
        }
        public LogRecord(Object[] ritem, DataRowStatus s, DataRow r)
        {
            RowItems = ritem;
            Status = s;
            Row = r;
        }
        public override bool Equals(object obj)
        {
            if (obj is LogRecord)
            {
                LogRecord l = (LogRecord)obj;
                for (int i = 0; i < RowItems.Length; i++)
                {
                    if (!RowItems[i].ToString().Equals(l.RowItems[i].ToString()))
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
