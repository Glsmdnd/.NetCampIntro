using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler yandaki gibi newlenemez IPersonelManager personmanager = new IPersonelManager();
           

           // IPersonelManager customerManager = new CustomerManager();
            
           // IPersonelManager employeeManager = new EmployeeManager();
            
            ProjectManager projectManager=new ProjectManager();
            projectManager.Add(new CustomerManager());
        }


            
        //class PersonelManager
        //{
        //    public void Add()
        //    {
        //        Console.WriteLine("eklendi");//implemented operation tamamlanmış operasyon içi doldurulmuş
        //    }

        //}
        //class CustomerManager:PersonelManager
        //kendi operasyonlarına e olarak kalıtım aldığı sınıfın operasyonlarıda eklenir
        //classtan çekseydi inheritance
        //{

        //}
        //perki Personelmanager sınıfı bir interface olsaydı

        interface IPersonelManager
            //interfacede bir şablon oluşturuyorum diyorumki customerda employee de bu şablona uymak zorunda (ayrıca kendi kodunu yazabilir içine)
        {
            void Add();//unimplemented operation içi boş doldurulmamış implemente edilen class larda add metodu imza aynı ama her class için add ayrıdır
            void Update();

        }
        class CustomerManager : IPersonelManager
        {//interface den çekerse implemet
            public void Add()
            {
                //müşteri ekleme kodları yazılır
                Console.WriteLine("Müşteri eklendi");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi");
            }
        }
        class EmployeeManager:IPersonelManager
        {
            public void Add()
            {
                //İşci ekleme kodları yazılır
                Console.WriteLine("işçi eklendi");
            }
            public void Update()
            {
                Console.WriteLine("İşçi güncellendi");
            }
        }
        class ProjectManager 
        {  //kendi içinde diğer addlerden bağımsız bir add metodu oluşturduk buradaki amaç diğer iki classtan farklı olarak bir merkezi yönetim gerçekleştirmek
            //IpersonManager interfai hem Employee hemde Customerin ref numarasını tutabildiğinden hangisini gönderirsek onu eklesin şeklinde
            public void Add(IPersonelManager personelManager)
            {
                personelManager.Add();
            }
        }
    }
}
