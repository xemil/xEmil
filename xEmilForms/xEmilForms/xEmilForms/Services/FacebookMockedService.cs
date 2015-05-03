﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using xEmilForms.Helpers;
using XLabs.Forms.Controls;

namespace xEmilForms.Services
{
    public class FacebookMockedService : IFacebookService
    {
        public Task SetLoggedInFacebookUserTask(FacebookUser fb)
        {
            var task = new Task(() =>
            {
                fb.FirstName = "Emil";
                fb.LastName = "Apelgren";
                fb.Name = "Emil Apelgren";
                fb.Id = "786311666";
                fb.Link = new Uri("http://www.facebook.com/786311666");
                fb.Gender = "male";
                fb.Locale = "en_US";

            });

            return task;

        }

        public Task SetProfilePictureTask(FacebookUser fb)
        {
            var task = new Task(() =>
            {
                fb.ProfileImage = new Image()
                {
                    Source = "FloId650x447.png",
                    Aspect = Aspect.AspectFit,
                    HeightRequest = 200,
                    WidthRequest = 200,


                };
            });

            return task;
        }

        public Task SetFriendListTask(FacebookUser fb)
        {

            var task = new Task(() =>
            {

                var friendList = GetFriendList();

                fb.FriendList = friendList;

            });
            
            return task;
        }

        private ObservableCollection<FacebookUser> GetFriendList()
        {
            //var list = new ObservableCollection<FacebookUser>();
            //string[] userNames;
            //for (int i = 0; i < 50; i++)
            //{
            //    userNames = GetUsername();
            //    var id = GetId().ToString();
            //    list.Add(new FacebookUser()
            //    {
            //        FirstName = userNames[0],
            //        LastName = userNames[1],
            //        Name = userNames[2],
            //        Gender = "male",
            //        Locale = "en_US",
            //        Id = id,
            //        Link = new Uri("http://www.facebook.com/" + id),
            //        ProfileImage = new Image()
            //        {

            //            Source = "icon.png"
            //        }
                    
            //    });
            //}

            var list = new ObservableCollection<FacebookUser>();
            var id1 = GetId();
            var fb1 = new FacebookUser()
            {
                FirstName = "Anna",
                LastName = "Svensson",
                Name = "Anna Svensson",
                Gender = "female",
                Locale = "en_US",
                Id = id1.ToString(),
                Link = new Uri("http://www.facebook.com/" + id1),
                ProfileImage = new Image()
                {
                    Source =
                        "icon.png"
                }
            };
            
            list.Add(fb1);


            var id2 = GetId();
            var fb2 = new FacebookUser()
            {
                FirstName = "Erik",
                LastName = "Andersson",
                Name = "Erik Andersson",
                Gender = "male",
                Locale = "en_US",
                Id = id1.ToString(),
                Link = new Uri("http://www.facebook.com/" + id1),
                ProfileImage = new Image()
                {
                    Source =
                        "icon.png"
                }
            };

            list.Add(fb2);


            var id3 = GetId();
            var fb3 = new FacebookUser()
            {
                FirstName = "Pelle",
                LastName = "Jönsson",
                Name = "Pelle Jönsson",
                Gender = "male",
                Locale = "en_US",
                Id = id1.ToString(),
                Link = new Uri("http://www.facebook.com/" + id1),
                ProfileImage = new Image()
                {
                    Source =
                        "icon.png"
                }
            };

            list.Add(fb3);



            var id4 = GetId();
            var fb4 = new FacebookUser()
            {
                FirstName = "Eva",
                LastName = "Svanberg",
                Name = "Eva Svanberg",
                Gender = "female",
                Locale = "en_US",
                Id = id1.ToString(),
                Link = new Uri("http://www.facebook.com/" + id1),
                ProfileImage = new Image()
                {
                    Source =
                        "icon.png"
                }
            };

            list.Add(fb4);

            
            return list;

        }

        private void addFriend(ObservableCollection<FacebookUser> list)
        {
            var userNames = GetUsername();
            var id = GetId().ToString();
            list.Add(new FacebookUser()
            {
                FirstName = userNames[0],
                LastName = userNames[1],
                Name = userNames[2],
                Gender = "male",
                Locale = "en_US",
                Id = id,
                Link = new Uri("http://www.facebook.com/" + id),
                ProfileImage = new Image()
                {
                    Source = "icon.png"
                }

            });
        }

        private string GetProfileURL()
        {
            var urlList = new List<string>();
            urlList.Add("http://i.imgur.com/jgAo9Z2.jpg");
            urlList.Add("http://i.imgur.com/LJ7DkGj.jpg");
            urlList.Add("http://i.imgur.com/F2Two6R.jpg");
            urlList.Add("http://i.imgur.com/hp9ghUt.jpg");
            urlList.Add("http://i.imgur.com/2kr3TIL.jpg");
            urlList.Add("http://i.imgur.com/aCA1WHG.jpg");

            var random = new Random();
            int r = random.Next(urlList.Count);

            return urlList.ElementAt(r);
        }

        private string[] GetUsername()
        {
            var result = new string[3];
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ÅÄÖ";
            var random = new Random();
            result[0] = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            result[1] = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            result[2] = result[0] + " " + result[1];

            return result;
        }

        private int GetId()
        {
            var random = new Random();
            var id = random.Next(100000000, 999999999);
            return id;
        }
    }
}
