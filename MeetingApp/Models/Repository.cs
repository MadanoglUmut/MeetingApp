using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> userList = new List<UserInfo>();

        static Repository(){
            userList.Add(new UserInfo(){
                Id = 1,
                Name = "Baris",
                WillAttend = true,
                Phone = "545100",
                Email = "mdnbaris@gmail.com"
            });

            userList.Add(new UserInfo(){
                Id = 2,
                Name = "Seyfi",
                WillAttend = true,
                Phone = "547100",
                Email = "mdnseyfi@gmail.com"
            });
            userList.Add(new UserInfo(){
                Id = 3,
                Name = "Derya",
                WillAttend = false,
                Phone = "77788",
                Email = "mdnderyas@gmail.com"
            });
        }

        public static List<UserInfo> UserList{
            get{
                return userList;
            }
        }

        public static void userListAdd(UserInfo user){
            user.Id = UserList.Count +1;
            userList.Add(user);
        }

        public static UserInfo? GetById(int id){
            return UserList.FirstOrDefault(user => user.Id == id);
        }
    }
}