namespace Visit
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SecondChance : DbContext
    {
        // Контекст настроен для использования строки подключения "SecondChance" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Visit.SecondChance" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "SecondChance" 
        // в файле конфигурации приложения.
        public SecondChance()
            : base("name=SecondChance")
        {
        }

        public DbSet<VisitProperties> Vistits { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}