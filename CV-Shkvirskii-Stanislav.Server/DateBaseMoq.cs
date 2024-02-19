﻿using CV_Shkvirskii_Stanislav.Server.models;
using System.Diagnostics;
using System.Reflection.PortableExecutable;

namespace CV_Shkvirskii_Stanislav.Server
{
    public static class DateBaseMoq
    {
        static List<ContentModel> content;
        static List<SkillModel> skills;
        
        static DateBaseMoq()
        {
            content = new List<ContentModel>()
            {
                new ContentModel(
                    [new AppellationModel("23. 12. 1989", "Shkvirskii Stanislav")],
                    "About Me",
                    new string[]
                    {
                        "My name is Stanislav, and I work as a full stack developer with more than two years of experience in the field of development.",
                        "I have confident skills in web development using C#, HTML, CSS, SCSS, JavaScript and TypeScript. Experience with Angular, Vue.js, ASP.NET and Blazor. I also have the skills to use SignalR to develop applications in real time.",
                        "I have experience in using MAUI Blazor, capable of creating mobile applications using technologies from Microsoft, as well as experience with APIs from Google and Firebase.",
                        "I like learning new things, researching technological innovation and learning about best practices in development.",
                        "I am open to communication and ready to collaborate successfully with the development team to achieve common goals.",
                        "I set myself high work standards and am committed to continually improving my skills to become the best in my profession."
                    }),

                new ContentModel(
                    [new AppellationModel("29. 02. 2024", "Full stack developer")],
                    "Experience",
                    new string[]
                    {
                        "For the last two years, I have successfully worked in the organization of 'Xanel' as a Full Stack Developer, improved my skills and accumulated experience in the technologies necessary for the successful work of a full stack developer.",
                        "My work included not only the implementation of web applications, but also their further improvement and optimization. I was actively involved in ensuring effective interaction between the frontend and backend, developing and improving the functionality in accordance with the requirements and expectations of users.",
                        "My work often required the ability to work from idea to release, including all stages of development from design to testing and implementation. Always prioritized high quality and efficiency of code, confident that clean and optimized code is a key element of successful development.",
                        "My task was to find and implement optimal solutions for achieving the best results.",
                        "In general, my work in the field of Full Stack Development has been an integral part of my professional growth, allowing me not only to fulfill the requirements of projects, but also to make my own contribution to the development and improvement of web technologies."
                    }),

                new ContentModel(
                    [new AppellationModel("20. 01. 2022", "ITVDN , '.NET Developer'"),
                    new AppellationModel("07. 03. 2023", "English language courses"),
                    new AppellationModel("01. 07. 2013", "DSAEU, 'Processes machines and equipment'")],
                    "Education",
                    new string[]
                    {
                        "The .NET Developer course gave me the opportunity to gain practical experience in developing websites and applications from scratch and based on ready-made solutions. I gained a lot of experience in performing tasks and projects, working both independently and in a team. I am ready to contribute to the development of high-quality web applications and products.",
                        "The Pre-Intermediate English course provided skills for confident communication. Developed language comprehension and improved reading, writing, speaking and listening skills.",
                        "After successfully completing my studies at the Faculty 'Processes of Machinery and Equipment' of Dnipropetrovsk State University, I received a high-quality education and significant professional skills in the field of mechanical engineering and equipment. My education provided deep knowledge and prepared me for the challenges associated with technical innovation and engineering. My logical thinking, developed during my studies, turns out to be a great advantage in my work as a programmer."
                    })
            };

            skills = new List<SkillModel>()
            {
                new SkillModel{ Title = "HTML", Lvl = 75 },
                new SkillModel{ Title = "Angular", Lvl = 85 },
                new SkillModel{ Title = "CSS", Lvl = 75 },
               new SkillModel{ Title = "Blazor", Lvl = 90 },
                new SkillModel{ Title = "SCSS", Lvl = 75 },
                new SkillModel{ Title = "ASP.NET", Lvl = 80 },
                new SkillModel{ Title = "JavaScript", Lvl = 80 },
                new SkillModel{ Title = "SignalR", Lvl = 75 },
                new SkillModel{ Title = "TypeScript", Lvl = 85 },
                new SkillModel{ Title = "MAUI Blazor", Lvl = 80 },
                new SkillModel{ Title = "C#", Lvl = 90 },
                new SkillModel{ Title = "Vue.js", Lvl = 50 },
                new SkillModel{ Title = "Web API", Lvl = 70 },
                new SkillModel{ Title = "Rest API", Lvl = 70 },
            };
        }

        public static List<ContentModel> GetContent()
        {
            return content;
        }

        public static List<SkillModel> GetSkills()
        {
            return skills;
        }
    }
}
