using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LessNeglect;

namespace TestLogger
{
    public class UserInfo
    {
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public DateTime DateCreated { get; set; }
        
        public string AccountId { get; set; }
        public string AccountName { get; set; }
    }

    // TODO - update the doc to use your own internal User model class, instead of the example UserInfo class.

    public static class Neglect
    {
        public static void LogEvent(UserInfo user, string eventName, string note = null)
        {
            try
            {
                LessNeglectApi.Client.CreateActionEvent(new LessNeglect.ActionEventCreateRequest()
                    .ForPerson(UserToPerson(user))
                    .WithEvent(new LessNeglect.ActionEvent()
                        .WithName(eventName)
                        .WithNote(note)));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void UpdatePerson(UserInfo user)
        {
            try
            {
                LessNeglectApi.Client.UpdatePerson(UserToPerson(user));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #region Helpers
        private static LessNeglect.Person UserToPerson(UserInfo user)
        {
            // TODO - update this to build a Person from your user data model
            return new Person()
                .WithEmail(user.Email)
                .WithName(user.FullName)
                .WithExternalId(user.Username)
                .WithProperties(GetAccountPropertiesDictionary(user));
        }

        private static Dictionary<string, object> GetAccountPropertiesDictionary(UserInfo user)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();

            // TODO - update this to create a nice dictionary to describe your user's relevant attributes
            //properties["account_level"] = user.AccountLevel;
            //properties["account_level_name"] = user.AccountLevelName;
            //properties["custom_domain"] = user.CustomDomainName;
            //properties["is_paying"] = user.IsPaying ? "1" : "0";

            properties["account_id"] = user.AccountId;
            properties["account_name"] = user.AccountName;
            properties["created_at"] = user.DateCreated;

            return properties;
        }
        #endregion
    }
}
