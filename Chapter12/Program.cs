namespace Chapter12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user1 = new User { Login="user1", Name="Ivan", IsPremium=true};
            User user2 = new User { Login="user2",Name="Vasily", IsPremium =true};
            User user3 = new User { Login="user3",Name="Petr",IsPremium=false};
            User user4 = new User { Login="user4",Name="Pavel",IsPremium =false};
            User user5 = new User { Login="user5",Name ="Jan",IsPremium=true};
            users.Add(user1); users.Add(user2); users.Add(user3); users.Add(user4);users.Add(user5);

            foreach (var u in users)
            {
                if (u.IsPremium)
                {
                    Console.WriteLine("Добрый день! {0}", u.Name);
                }    
                else
                {
                    ShowAds();
                }    
            }
            Console.WriteLine("Hello, World!");
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}