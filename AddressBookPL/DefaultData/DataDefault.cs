﻿using AddressBookEL.IdentityModels;
using Microsoft.AspNetCore.Identity;

namespace AddressBookPL.DefaultData
{
    public static class DataDefault
    {
        public static IApplicationBuilder Data(this IApplicationBuilder app) //extension metot
        {

            // managerleri kullanabilmek çin extenrion metot oluturduk

            // bir metot extenrion metot ise parametresinde this kelimesi vardır

            using var scopedServices = app.ApplicationServices.CreateScope();

            var serviceProvider = scopedServices.ServiceProvider;

            var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            //city managerleri da ilerleyen günlerde üreteceğiz illeri eklemek için


            CheckAndCreateRoles(roleManager); // roleManager oluştu ve şimdi rolleri oluşturan metodu çağırabiliriz


            return app;
        }
        public static void CheckAndCreateRoles(RoleManager<AppRole> roleManager)
        {
            try
            {
                //admin // costumer // guest vb...
                string[] roles = new string[]
                    {"admin", "customer","guest"};

                // rolleri tek tek dönü sisteme olup olmadığına bakacağız yoksa ekleyeceğiz

                foreach (var item in roles)
                {
                    //ROLDEN YOK MU?
                    if (!roleManager.RoleExistsAsync(item.ToLower()).Result)
                    {
                        //rolden yokmuş ekleyelim
                        AppRole role = new AppRole()
                        {
                            Name = item
                        };

                        var result = roleManager.CreateAsync(role).Result;

                    }

                }

            }
            catch (Exception ex)
            {

                // ex loglanabilir
                // yazılımcıya acil başlıklı email gönderilebilir
            }

        }

        public static string AsalDurum(this int x)
        {
            return "evet asal";
        }

        public static bool AsalMidir(this int number)
        {
            //işlemler
            for (int i = number; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static IApplicationBuilder Maide(this IApplicationBuilder app)
        {


            return app;
        }
    }
}

