
namespace WpfApp2
{
    interface UpdateDataWindow
    {
        void loadData(int p);
        void add();
        void edit();
        int update();
        void delete();
        void undo();
        void redo();
    }
}
