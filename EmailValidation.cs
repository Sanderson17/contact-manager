﻿//using System;
//using System.Globalization;
//using System.Text.RegularExpressions;

//namespace contact_manager
//{
//    class EmailValidation
//    {
//        public static bool IsValidEmail(string emailAddress)
//        {
//            if (string.IsNullOrWhiteSpace(emailAddress))
//                return false;

//            try
//            {
//                // Normalize the domain
//                emailAddress = Regex.Replace(emailAddress, @"(@)(.+)$", DomainMapper,
//                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

//                // Examines the domain part of the email and normalizes it.
//                string DomainMapper(Match match)
//                {
//                    // Use IdnMapping class to convert Unicode domain names.
//                    var idn = new IdnMapping();

//                    // Pull out and process domain name (throws ArgumentException on invalid)
//                    string domainName = idn.GetAscii(match.Groups[2].Value);

//                    return match.Groups[1].Value + domainName;
//                }
//            }
//            catch (RegexMatchTimeoutException e)
//            {
//                return false;
//            }
//            catch (ArgumentException e)
//            {
//                return false;
//            }

//            try
//            {
//                return Regex.IsMatch(emailAddress,
//                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
//                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
//            }
//            catch (RegexMatchTimeoutException)
//            {
//                return false;
//            }
//        }
//    }
//}