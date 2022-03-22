using System;

namespace classproject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1, 2
            //Notebook notebook1 = new Notebook
            //{
            //    Name = "vivobook",
            //    BrandName = "ASUS",
            //    Price = 1600
            //};

            //Notebook notebook2 = new Notebook();
            //notebook2.Name = "pavilion";
            //notebook2.BrandName = "hd";
            //notebook2.Price = 2000;



            //Notebook[] notebooks = { notebook1, notebook2 };

            //Console.WriteLine("minimum qiymeti daxil edin:");
            //string minPricestr = Console.ReadLine();
            //double minPrice = Convert.ToInt32(minPricestr);
            //Console.WriteLine("maksimum qiymeti daxil edin:");
            //string maxPricestr = Console.ReadLine();
            //double maxPrice = Convert.ToInt32(maxPricestr);

            //Notebook[] newNotebooks = NotebookArray(notebooks, minPrice, maxPrice);

            //foreach (var item in newNotebooks)
            //{
            //    Console.WriteLine($"notebookun adi: {item.Name}, notebookun brand adi: {item.BrandName}, notebookun qiymeti: {item.Price}");
            //}
            #endregion


            #region task 3 (tamamlanmayib)
            //Console.WriteLine("nece kitab isteyirsiniz?");
            //string sizestr = Console.ReadLine();
            //int size = Convert.ToInt32(sizestr);
            //Console.WriteLine($"{size} eded kitab daxil edin");

            //Library library1 = new Library
            //{
            //    Books = new Book[size]
            //};



            ////for (int i = 0; i < size; i++)
            ////{
            ////    do
            ////    {
            //        Console.WriteLine("kitabin nomresini daxil edin:");
            //        library1.Books[i].No = Convert.ToInt32(Console.ReadLine());
            //        for (int j = 0; j < library1.Books.Length; j++)
            //        {
            //            if (library1.Books[i].No == library1.Books[j].No)
            //            {
            //                Console.WriteLine("eyni nomre deyerinde 2ci kitab elave edile bilmez!");
            //                library1.Books[i].No = Convert.ToInt32(Console.ReadLine());
            //            }
            //        }
            //    } while (library1.Books[i].No < 0);
            //}
            #endregion 


        }

        static Notebook[] NotebookArray(Notebook[] array, double minPrice, double maxPrice)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.Price > minPrice && item.Price < maxPrice)
                    count++;
            }
            Notebook[] newNotebooks = new Notebook[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Price > minPrice && array[i].Price < maxPrice)
                {
                    newNotebooks[i] = array[i];
                    j++;
                }
            }
            return newNotebooks;
        }


    }
}
