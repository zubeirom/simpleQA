using System;
using System.Collections.Generic;
using System.Linq;
using SimpleQa.Entities;
using System.Threading.Tasks;

namespace SimpleQa
{
    public static class SimpleQaExtensions
    {
        public static void EnsureSeedDataForContext(this SimpleQaContext context)
        {


            var questions = new List<Question>()
            {
                new Question()
                {
                    Title = "What is the best programming language?",
                    Message = "Tried the best language",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "Python duuuuuude"
                        },
                        new Comment()
                        {
                            Content = "No, don't listen to the guy, its JavaScript all the way"
                        }
                    }
                },

                new Question()
                {
                    Title = "How do I learn programming?",
                    Message = "Can I get sources",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "W3 schools try it"
                        },
                        new Comment()
                        {
                            Content = "You are not worthy"
                        }
                    }
                },

                new Question()
                {
                    Title = "What is better ios or android",
                    Message = "Trying to buy a new phone right, please keep it holy",
                    Comments = new List<Comment>()
                    {
                        new Comment()
                        {
                            Content = "F*** Android !!!!"
                        },
                        new Comment()
                        {
                            Content = "Apple sheeps!!!"
                        }
                    }
                }
            };
        }
    }
}