﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                    .Android
                    .ApkFile("C:\\Users\\mike\\Documents\\Visual Studio 2017\\Projects\\MDT17AppForms\\MDT17AppForms\\MDT17AppForms.Android\\bin\\Release\\MDT17AppForms.Android-Signed.apk")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

