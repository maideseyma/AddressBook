using AddressBookEL.IdentityModels;
using Microsoft.AspNetCore.Identity;

namespace AddressBookPL.DefaultData
{
    public class DataDefaultXihan
    {

        public void CheckAndCreateRoles(RoleManager<AppRole> roleManager)
        {
            try
            {
                //admin // costumer // guest vb...
                string[] roles = new string[]
                    {"Admin", "Customer","Guest"};

                // rolleri tek tek dönü sisteme olup olmadığına bakacağız yoksa ekleyeceğiz

                foreach (var item in roles)
                {
                    //ROLDEN YOK MU?
                    if (!roleManager.RoleExistsAsync(item.ToLower()).Result)
                    {
                        //rolden yokmuş ekleyelim
                        AppRole role = new AppRole()
                        {
                            Name = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {item}"
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

    }
}
