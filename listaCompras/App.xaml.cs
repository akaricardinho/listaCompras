using listaCompras.Helpers;

namespace listaCompras
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper _db;

        public static SQLiteDataBaseHelper Db
        {
            get
            {
                if(_db == null)
                {
                    string path = Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData  
                        ), "banco_sqlite_compras.db3"
                    );

                    _db = new SQLiteDataBaseHelper( path );

                } // Fecha if verificando se _db é null
                return _db;
            } // Fecha método get
        } // Fecha propriedade db
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
