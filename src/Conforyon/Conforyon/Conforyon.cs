#region Imports

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Site   : www.Taiizor.com
//     Created: 04.Jul.2019
//     Changed: 03.Aug.2020
//     Version: 1.3.8.9
//
// |---------DO-NOT-REMOVE---------|

namespace Conforyon
{
    public static class Conforyon
    {
        #region Variables

        private const string ErrorTitle = " (CN-CL";
        private const string ErrorMessage = "Error!";
        private const int VariableLength = 15;

        #endregion

        private static readonly string[] SizeTypes = {
            "Bit",
            "Byte",
            "KB",
            "MB",
            "GB",
            "TB",
            "PB",
            "EB",
            "ZB",
            "YB"
        };

        private static readonly string[] SymbolsMath = {
            "-",
            "+"
        };

        private static readonly string[] SymbolsCalc = {
            "E",
            "B",
            "+",
            "-"
        };

        public static string OtoVeriÇevir(string GelenVeri, string GelenTür, bool TürYazı = false, bool Ondalık = false, bool Virgül = false, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (GelenVeri.Length <= VariableLength && Array.IndexOf(SizeTypes, GelenTür) >= 0 && VirgülSonrası >= 0 && VirgülSonrası <= 99 && !Regex.IsMatch(GelenVeri, "[^0-9]") && !GelenVeri.StartsWith("0") && Kontrol(GelenVeri) && Kontrol(GelenTür))
                {
                    string Tür = null;
                    if (GelenTür == SizeTypes[SizeTypes.Length - 1])
                        Tür = SizeTypes[SizeTypes.Length - 1];
                    else
                    {
                        for (int i = Array.IndexOf(SizeTypes, GelenTür); i < SizeTypes.Length; i++)
                        {
                            if (VeriÇevir(GelenVeri, GelenTür, SizeTypes[i], false, false, 0, Hata) == "0")
                            {
                                Tür = SizeTypes[i - 1];
                                break;
                            }
                            else
                            {
                                if (SizeTypes[i] == SizeTypes[SizeTypes.Length - 1])
                                    Tür = SizeTypes[i];
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(Tür))
                        return Hata;
                    else
                    {
                        if (GelenTür != Tür)
                        {
                            string Sonuç = VeriÇevir(GelenVeri, GelenTür, Tür, Ondalık, Virgül, VirgülSonrası, Hata);
                            if (TürYazı == false || Sonuç == Hata)
                                return Sonuç;
                            else
                                return Sonuç + " " + Tür;
                        }
                        else
                        {
                            string Sonuç = null;
                            if (Ondalık == false && Virgül == false)
                                Sonuç = GelenVeri;
                            else
                            {
                                if (Ondalık == true && Virgül == false)
                                    Sonuç = Conforyon.Ondalık(GelenVeri);
                                else if (Ondalık == false && Virgül == true)
                                    Sonuç = Conforyon.Virgül(GelenVeri, VirgülSonrası);
                                else
                                    Sonuç = OndalıkVirgül(GelenVeri, VirgülSonrası);
                            }
                            if (TürYazı == false)
                                return Sonuç;
                            else
                                return Sonuç + " " + Tür;
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1O!)";
            }
        }

        public static string VeriÇevir(string GelenVeri, string GelenTür, string DönüştürülecekTür, bool Ondalık = false, bool Virgül = false, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                string Veri;
                if (GelenVeri.Length <= VariableLength && Array.IndexOf(SizeTypes, GelenTür) >= 0 && Array.IndexOf(SizeTypes, DönüştürülecekTür) >= 0 && VirgülSonrası >= 0 && VirgülSonrası <= 99 && !Regex.IsMatch(GelenVeri, "[^0-9]") && !GelenVeri.StartsWith("0") && Kontrol(GelenVeri) && Kontrol(GelenTür) && Kontrol(DönüştürülecekTür))
                {
                    if (GelenTür == "Bit")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8192", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8388608", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8589934592", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8796093022208", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "9007199254740992", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (8796093022208 * 2048).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (8796093022208 * 3072).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (8796093022208 * 4096).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "Byte")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606846976", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (1125899906842624 * 2048).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (1125899906842624 * 3072).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "KB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8192", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606846976", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, (1125899906842624 * 2048).ToString(), Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "MB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8388608", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606847000", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "GB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8589934592", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "TB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "8796093022208", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "PB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "9007199254740992", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "EB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "9223372036854775808", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606846976", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "ZB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "9444732965739290427392", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1180591620717411303424", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606846976", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "YB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata, false, true);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else if (GelenTür == "YB")
                    {
                        if (DönüştürülecekTür == GelenTür)
                            return SonKontrol(GelenVeri, Ondalık, Virgül, VirgülSonrası, Hata);
                        else
                        {
                            if (DönüştürülecekTür == "Bit")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "9671406556917033397649408", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "Byte")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1208925819614629174706176", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "KB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1180591620717411303424", Virgül, Hata, true);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "MB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1152921504606846976", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "GB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1125899906842624", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "TB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1099511627776", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "PB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1073741824", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "EB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1048576", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else if (DönüştürülecekTür == "ZB")
                            {
                                if (SayıKontrol(GelenVeri) == true)
                                    Veri = VeriFormat(GelenVeri, "1024", Virgül, Hata);
                                else
                                    return Hata;
                            }
                            else
                                return Hata;
                            return SonKontrol(Veri, Ondalık, Virgül, VirgülSonrası, Hata);
                        }
                    }
                    else
                        return Hata;
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1V!)";
            }
        }

        public static string IsıÇevir(string Veri, string Mod, bool Ondalık, bool Virgül, int VirgülSonrası = 0, bool Yazı = true, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri) && Kontrol(Mod))
                {
                    if (Mod == "C=>F" || Mod == "F=>C")
                    {
                        if (Mod == "C=>F")
                        {
                            if (Yazı == false)
                                return SonKontrol2((Convert.ToDouble(Veri) * 9 / 5 + 32).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                            else
                                return SonKontrol2((Convert.ToDouble(Veri) * 9 / 5 + 32).ToString(), Ondalık, Virgül, VirgülSonrası, Hata) + " F";
                        }
                        else
                        {
                            if (Convert.ToInt64(Veri) >= 32)
                            {
                                if (Yazı == false)
                                    return SonKontrol2(((Convert.ToDouble(Veri) - 32) * 5 / 9).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                                else
                                    return SonKontrol2(((Convert.ToDouble(Veri) - 32) * 5 / 9).ToString(), Ondalık, Virgül, VirgülSonrası, Hata) + " C";
                            }
                            else
                            {
                                if (Yazı == false)
                                    return SonKontrol2("0", Ondalık, Virgül, VirgülSonrası, Hata);
                                else
                                    return SonKontrol2("0", Ondalık, Virgül, VirgülSonrası, Hata) + " C";
                            }
                        }
                    }
                    else
                        return Hata;
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1I!)";
            }
        }

        public static string HEXtoRGB(string Veri, int Mod = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length == 6 && Mod >= 0 && Mod <= 10 && Kontrol(Veri))
                {
                    Color HexColor = ColorTranslator.FromHtml("#" + Veri);
                    if (Mod == 0)
                        return HexColor.R + ", " + HexColor.G + ", " + HexColor.B;
                    else if (Mod == 1)
                        return HexColor.R + " " + HexColor.G + " " + HexColor.B;
                    else if (Mod == 2)
                        return HexColor.R + " - " + HexColor.G + " - " + HexColor.B;
                    else if (Mod == 3)
                        return "R: " + HexColor.R + " G: " + HexColor.G + " B: " + HexColor.B;
                    else if (Mod == 4)
                        return "R: " + HexColor.R + ", G: " + HexColor.G + ", B: " + HexColor.B;
                    else if (Mod == 5)
                        return "R: " + HexColor.R;
                    else if (Mod == 6)
                        return "G: " + HexColor.G;
                    else if (Mod == 7)
                        return "B: " + HexColor.B;
                    else if (Mod == 8)
                        return HexColor.R.ToString();
                    else if (Mod == 9)
                        return HexColor.G.ToString();
                    else if (Mod == 10)
                        return HexColor.B.ToString();
                    else
                        return Veri;
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1H!)";
            }
        }

        public static string RGBtoHEX(string R, string G, string B, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (R.Length <= 3 && R.Length >= 1 && G.Length <= 3 && G.Length >= 1 && B.Length <= 3 && B.Length >= 1 && SayıKontrol(R, true) && SayıKontrol(G, true) && SayıKontrol(B, true))
                {
                    if ((R.Length >= 2 && R.StartsWith("0")) == true || (G.Length >= 2 && G.StartsWith("0")) == true || (B.Length >= 2 && B.StartsWith("0")) == true)
                        return Hata;
                    else
                    {
                        if (Convert.ToInt32(R) >= 0 && Convert.ToInt32(R) <= 255 && Convert.ToInt32(G) >= 0 && Convert.ToInt32(G) <= 255 && Convert.ToInt32(B) >= 0 && Convert.ToInt32(B) <= 255)
                        {
                            Color RGBColor = Color.FromArgb(Convert.ToInt32(R), Convert.ToInt32(G), Convert.ToInt32(B));
                            if (Mod == true)
                                return "#" + RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                            else
                                return RGBColor.R.ToString("X2") + RGBColor.G.ToString("X2") + RGBColor.B.ToString("X2");
                        }
                        else
                            return Hata;
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1R!)";
            }
        }

        public static string TEXTtoASCII(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    string Sonuç = "";
                    byte[] HarfByte;
                    for (int i = 0; i < Veri.Length; i++)
                    {
                        HarfByte = UTF8Encoding.UTF8.GetBytes(Veri.Substring(i, 1)); //Encoding.ASCII
                        if (i < Veri.Length - 1)
                            Sonuç += HarfByte[0] + ",";
                        else
                            Sonuç += HarfByte[0].ToString();
                    }
                    return Sonuç;
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1T!)";
            }
        }

        public static string ASCIItoTEXT(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri))
                {
                    string Sonuç = "";
                    char[] Ayraçlar = { ',' };
                    string[] Harfler = Veri.Split(Ayraçlar);
                    for (int i = 0; i < Harfler.Length; i++)
                    {
                        if (SayıKontrol(Harfler[i], true) == true && Harfler[i].Length >= 1 && Harfler[i].Length <= 3 && Convert.ToInt32(Harfler[i]) >= 0 && Convert.ToInt32(Harfler[i]) <= 255)
                            Sonuç += UTF8Encoding.UTF8.GetString(new byte[] { Convert.ToByte(Harfler[i]) }); //Encoding.ASCII
                        else
                            return Hata;
                    }
                    return Sonuç;
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1A!)";
            }
        }

        public static string CHARtoBASE64(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                    return Convert.ToBase64String(Encoding.UTF8.GetBytes(Veri));
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C!)";
            }
        }

        public static string BASE64toCHAR(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri))
                {
                    if (Veri.EndsWith("="))
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Veri));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Veri + "="));
                            }
                            catch
                            {
                                try
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Veri.Remove(Veri.Length - 1)));
                                }
                                catch
                                {
                                    return Encoding.UTF8.GetString(Convert.FromBase64String(Veri.Remove(Veri.Length - 2)));
                                }
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            return Encoding.UTF8.GetString(Convert.FromBase64String(Veri));
                        }
                        catch
                        {
                            try
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Veri + "="));
                            }
                            catch
                            {
                                return Encoding.UTF8.GetString(Convert.FromBase64String(Veri + "=="));
                            }
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1B!)";
            }
        }

        public static string CHARtoMD5(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    using (MD5 MD5 = MD5.Create())
                    {
                        MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Veri));
                        byte[] Sonuç = MD5.Hash;
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C2!)";
            }
        }

        public static string FILEtoMD5(string Yol, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (File.Exists(Yol))
                {
                    using (MD5 MD5 = new MD5CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Yol))
                        {
                            var Hash = MD5.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1F1!)";
            }
        }

        public static string CHARtoSHA1(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    using (SHA1 SHA1 = SHA1.Create())
                    {
                        byte[] Sonuç = SHA1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Veri));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C3!)";
            }
        }

        public static string FILEtoSHA1(string Yol, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (File.Exists(Yol))
                {
                    using (SHA1 SHA1 = new SHA1CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Yol))
                        {
                            var Hash = SHA1.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1F2!)";
            }
        }

        public static string CHARtoSHA256(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    using (SHA256 SHA256 = SHA256.Create())
                    {
                        byte[] Sonuç = SHA256.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Veri));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C4!)";
            }
        }

        public static string FILEtoSHA256(string Yol, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (File.Exists(Yol))
                {
                    using (SHA256 SHA256 = new SHA256CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Yol))
                        {
                            var Hash = SHA256.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1F3!)";
            }
        }

        public static string CHARtoSHA384(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    using (SHA384 SHA384 = SHA384.Create())
                    {
                        byte[] Sonuç = SHA384.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Veri));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C5!)";
            }
        }

        public static string FILEtoSHA384(string Yol, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (File.Exists(Yol))
                {
                    using (SHA384 SHA384 = new SHA384CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Yol))
                        {
                            var Hash = SHA384.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1F4!)";
            }
        }

        public static string CHARtoSHA512(string Veri, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= 32767 && Kontrol(Veri, true))
                {
                    using (SHA512 SHA512 = SHA512.Create())
                    {
                        byte[] Sonuç = SHA512.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Veri));
                        StringBuilder Yapı = new StringBuilder();
                        for (int i = 0; i < Sonuç.Length; i++)
                            Yapı.Append(Sonuç[i].ToString("x2"));
                        return Yapı.ToString();
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C6!)";
            }
        }

        public static string FILEtoSHA512(string Yol, bool Mod = false, string Hata = ErrorMessage)
        {
            try
            {
                if (File.Exists(Yol))
                {
                    using (SHA512 SHA512 = new SHA512CryptoServiceProvider())
                    {
                        using (var Stream = File.OpenRead(Yol))
                        {
                            var Hash = SHA512.ComputeHash(Stream);
                            return Mod == false ? BitConverter.ToString(Hash).Replace("-", "").ToLowerInvariant() : BitConverter.ToString(Hash).Replace("-", "").ToUpperInvariant();
                        }
                    }
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1F5!)";
            }
        }

        public static string INCHtoCM(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                    return SonKontrol2((Convert.ToInt64(Veri) * 2.54).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1I2!)";
            }
        }

        public static string INCHtoPX(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                {
                    string Sonuç = (Convert.ToInt64(Veri) * 2.54 * 37.79527559055118).ToString();
                    return SonKontrol2(Sonuç, Ondalık, Virgül, VirgülSonrası, Hata);
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1I3!)";
            }
        }
        public static string CMtoINCH(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                {
                    if (Convert.ToInt64(Veri) >= 3)
                        return SonKontrol2((Convert.ToInt64(Veri) / 2.54).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                    else
                        return SonKontrol2("0", Ondalık, Virgül, VirgülSonrası, Hata);
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C7!)";
            }
        }

        public static string CMtoPX(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                    return SonKontrol2((Convert.ToInt64(Veri) * 37.79527559055118).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1C8!)";
            }
        }

        public static string PXtoCM(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                {
                    if (Convert.ToInt64(Veri) >= 38)
                        return SonKontrol2((Convert.ToInt64(Veri) / 37.79527559055118).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                    else
                        return SonKontrol2("0", Ondalık, Virgül, VirgülSonrası, Hata);
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1P!)";
            }
        }

        public static string PXtoINCH(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Veri.Length <= VariableLength && SayıKontrol(Veri) == true && !Veri.StartsWith("0") && VirgülSonrası >= 0 && VirgülSonrası <= 99 && Kontrol(Veri))
                {
                    if (Convert.ToInt64(Veri) >= 96)
                        return SonKontrol2((Convert.ToInt64(Veri) / 37.79527559055118 / 2.54).ToString(), Ondalık, Virgül, VirgülSonrası, Hata);
                    else
                        return SonKontrol2("0", Ondalık, Virgül, VirgülSonrası, Hata);
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1P2!)";
            }
        }

        public static bool SayıKontrol(string Veri, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Regex.IsMatch(Veri, "[^0-9]"))
                    return false;
                else
                {
                    if (Mod2 == false)
                    {
                        if (Mod == false)
                        {
                            Convert.ToInt64(Veri);
                            return true;
                        }
                        else
                        {
                            Convert.ToInt32(Veri);
                            return true;
                        }
                    }
                    else
                        return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static string Arama(string Veri1, string[] Veri2, int Mod = 1, string Hata = ErrorMessage)
        {
            try
            {
                if (Mod >= 1 && Mod <= 3)
                {
                    string Durum = "N";
                    if (Mod == 1)
                    {
                        if (Veri2.Length > 1)
                        {
                            foreach (string Harf in Veri2)
                            {
                                if (Veri1.Contains(Harf))
                                {
                                    Durum = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Veri1.Contains(Veri2[0]))
                            Durum = "Y";
                    }
                    else if (Mod == 2)
                    {
                        if (Veri2.Length > 1)
                        {
                            foreach (string Harf in Veri2)
                            {
                                if (Veri1.StartsWith(Harf))
                                {
                                    Durum = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Veri1.StartsWith(Veri2[0]))
                            Durum = "Y";
                    }
                    else if (Mod == 3)
                    {
                        if (Veri2.Length > 1)
                        {
                            foreach (string Harf in Veri2)
                            {
                                if (Veri1.EndsWith(Harf))
                                {
                                    Durum = "Y";
                                    break;
                                }
                            }
                        }
                        else if (Veri1.EndsWith(Veri2[0]))
                            Durum = "Y";
                    }
                    if (Durum == "N")
                        return "N";
                    else
                        return "Y";
                }
                else
                    return Hata;
            }
            catch
            {
                return Hata + ErrorTitle + "1A2!)";
            }
        }

        private static string VeriFormat(string GelenVeri, string KatSayı, bool Virgül, string Hata = ErrorMessage, bool Mod = false, bool Mod2 = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (SayıKontrol(KatSayı.ToString()) == true)
                    {
                        string Veri1, Veri2, Veri3;
                        if (Virgül == true)
                        {
                            if (Mod2 == false)
                            {
                                Veri2 = (Convert.ToInt64(GelenVeri) * Convert.ToDouble(KatSayı)).ToString();
                                Veri3 = (Convert.ToInt64(GelenVeri) * Convert.ToInt64(KatSayı)).ToString();
                            }
                            else
                            {
                                Veri2 = (Convert.ToInt64(GelenVeri) / Convert.ToDouble(KatSayı)).ToString();
                                Veri3 = (Convert.ToInt64(GelenVeri) / Convert.ToInt64(KatSayı)).ToString();
                            }
                            if (Arama(Veri2, SymbolsCalc, 1, Hata) == "Y")
                            {
                                if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                    Veri1 = Veri2;
                                else
                                    Veri1 = Veri3;
                            }
                            else if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                    Veri1 = Veri2;
                                else
                                    Veri1 = Veri3;
                            else
                                Veri1 = Veri2;
                        }
                        else
                        {
                            if (Mod2 == false)
                            {
                                Veri2 = (Convert.ToInt64(GelenVeri) * Convert.ToDouble(KatSayı)).ToString();
                                Veri3 = (Convert.ToInt64(GelenVeri) * Convert.ToInt64(KatSayı)).ToString();
                            }
                            else
                            {
                                Veri2 = (Convert.ToInt64(GelenVeri) / Convert.ToDouble(KatSayı)).ToString();
                                Veri3 = (Convert.ToInt64(GelenVeri) / Convert.ToInt64(KatSayı)).ToString();
                            }
                            if (Arama(Veri2, SymbolsCalc, 1, Hata) == "Y")
                            {
                                if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                    Veri1 = Veri2;
                                else
                                    Veri1 = Veri3;
                            }
                            else if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                if (Arama(Veri3, SymbolsMath, 2, Hata) == "Y")
                                    Veri1 = Veri2;
                                else
                                    Veri1 = Veri3;
                            else
                                Veri1 = Veri3;
                        }
                        if (string.IsNullOrEmpty(Veri1))
                            return Hata;
                        else
                            return Veri1;
                    }
                    else
                        return Hata;
                }
                else
                {
                    if (Mod2 == false)
                        return (Convert.ToInt64(GelenVeri) * Convert.ToDouble(KatSayı)).ToString();
                    else
                        return (Convert.ToInt64(GelenVeri) / Convert.ToDouble(KatSayı)).ToString();
                }
            }
            catch
            {
                return Hata + ErrorTitle + "1V2!)";
            }
        }

        private static string Ondalık(string Veri)
        {
            try
            {
                if (Veri.Contains("E") || Veri.Contains("B") || Veri.Contains("+") || Veri.Contains("-"))
                    return Veri;
                else
                {
                    if (Veri.Contains(","))
                    {
                        char[] Ayraçlar = { ',', '.' };
                        string[] Veriler = Veri.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Veriler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            Sonuç = "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            Sonuç.Replace("0", "");
                        return Sonuç + "," + Veriler[1];
                    }
                    else
                    {
                        if (Veri.Length > 2)
                        {
                            if (SayıKontrol(Veri) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Veri));
                            else
                                return string.Format("{0:0,0}", Veri);
                        }
                        else
                            return Veri;
                    }
                }
            }
            catch (Exception Hata)
            {
                return Hata + ErrorTitle + "1O2!)";
            }
        }

        private static string Ondalık2(string Veri)
        {
            try
            {
                if (Veri.Contains("E") || Veri.Contains("B") || Veri.Contains("+") || Veri.Contains("-"))
                    return Veri;
                else
                {
                    if (Veri.Contains(","))
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Veriler = Veri.Split(Ayraçlar);
                        string Sonuç = string.Format("{0:0,0}", Convert.ToInt64(Veriler[0]));
                        if (Sonuç.Length == 2 && Sonuç == "00")
                            return "0";
                        else if (Sonuç.Length == 2 && Sonuç.StartsWith("0") && !Sonuç.EndsWith("0"))
                            return Sonuç.Replace("0", "");
                        else
                            return Sonuç;
                    }
                    else
                    {
                        if (Veri.Length > 2)
                        {
                            if (SayıKontrol(Veri) == true)
                                return string.Format("{0:0,0}", Convert.ToInt64(Veri));
                            else
                                return string.Format("{0:0,0}", Veri);
                        }
                        else
                            return Veri;
                    }
                }
            }
            catch (Exception Hata)
            {
                return Hata + ErrorTitle + "1O3!)";
            }
        }

        private static string Virgül(string Veri, int VirgülSonrası = 0)
        {
            try
            {
                if (Veri.Contains("E") || Veri.Contains("B") || Veri.Contains("+") || Veri.Contains("-"))
                    return Veri;
                else
                {
                    if (Veri.Contains(",") && VirgülSonrası != 0)
                    {
                        char[] Ayraçlar = { ',' };
                        string[] Veriler = Veri.Split(Ayraçlar);
                        if (VirgülSonrası <= Veriler[1].Length)
                            return Veriler[0] + "," + Veriler[1].Substring(0, VirgülSonrası);
                        else
                        {
                            string Işlem = Veriler[0] + "," + Veriler[1].Substring(0, Veriler[1].Length);
                            int Işlem2 = VirgülSonrası - Veriler[1].Length;
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                            return Işlem;
                        }
                    }
                    else
                    {
                        if (VirgülSonrası == 0)
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Veriler = Veri.Split(Ayraçlar);
                            return Veriler[0];
                        }
                        else
                        {
                            string Işlem = ",";
                            for (int i = 0; i < VirgülSonrası; i++)
                                Işlem += "0";
                            return Veri + Işlem;
                        }
                    }
                }
            }
            catch (Exception Hata)
            {
                return Hata + ErrorTitle + "1V3!)";
            }
        }

        private static string Virgül2(string Veri, int VirgülSonrası = 0)
        {
            try
            {
                if (Veri.Contains("E") || Veri.Contains("B") || Veri.Contains("+") || Veri.Contains("-"))
                    return Veri;
                else
                {
                    if (VirgülSonrası <= Veri.Length)
                        if (Veri == ",")
                            return Veri.Substring(0, VirgülSonrası) + "0";
                        else
                            return Veri.Substring(0, VirgülSonrası);
                    else
                    {
                        string Işlem = Veri.Substring(0, Veri.Length);
                        int Işlem2 = VirgülSonrası - Veri.Length;
                        if (Veri == ",")
                        {
                            for (int i = 0; i <= Işlem2; i++)
                                Işlem += "0";
                        }
                        else
                        {
                            for (int i = 0; i < Işlem2; i++)
                                Işlem += "0";
                        }
                        return Işlem;
                    }
                }
            }
            catch (Exception Hata)
            {
                return Hata + ErrorTitle + "1v4!)";
            }
        }

        private static string OndalıkVirgül(string Veri, int VirgülSonrası = 0)
        {
            try
            {
                if (Veri.Contains("E") || Veri.Contains("B") || Veri.Contains("+") || Veri.Contains("-"))
                    return Veri;
                else
                {
                    if (VirgülSonrası == 0)
                        return Ondalık2(Veri);
                    else
                    {
                        if (Veri.Contains(","))
                        {
                            char[] Ayraçlar = { ',' };
                            string[] Veriler = Veri.Split(Ayraçlar);
                            return Ondalık2(Veriler[0]) + "," + Virgül2(Veriler[1], VirgülSonrası);
                        }
                        else
                            return Ondalık2(Veri) + Virgül2(",", VirgülSonrası);
                    }
                }
            }
            catch (Exception Hata)
            {
                return Hata + ErrorTitle + "1O4!)";
            }
        }

        private static string SonKontrol(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Ondalık == false && Virgül == false)
                {
                    if (string.IsNullOrEmpty(Veri))
                        return Hata;
                    else
                        return Veri;
                }
                else
                {
                    if (Ondalık == true && Virgül == false)
                        return Conforyon.Ondalık(Veri);
                    else if (Ondalık == false && Virgül == true)
                        return Conforyon.Virgül(Veri, VirgülSonrası);
                    else
                        return OndalıkVirgül(Veri, VirgülSonrası);
                }
            }
            catch
            {
                return Hata + ErrorTitle + "1S!)";
            }
        }

        private static string SonKontrol2(string Veri, bool Ondalık, bool Virgül, int VirgülSonrası = 0, string Hata = ErrorMessage)
        {
            try
            {
                if (Ondalık == false && Virgül == false)
                {
                    if (string.IsNullOrEmpty(Veri))
                        return Hata;
                    else
                        return SonKontrol(Veri, false, true, 0, Hata);
                }
                else
                {
                    if (Ondalık == true && Virgül == false)
                        return SonKontrol(Veri, true, true, 0, Hata);
                    else if (Ondalık == false && Virgül == true)
                        return SonKontrol(Veri, false, true, VirgülSonrası, Hata);
                    else
                        return OndalıkVirgül(Veri, VirgülSonrası);
                }
            }
            catch
            {
                return Hata + ErrorTitle + "1S2!)";
            }
        }

        private static bool Kontrol(string Veri, bool Mod = false)
        {
            try
            {
                if (Mod == false)
                {
                    if (Veri != "" && !string.IsNullOrEmpty(Veri) && !string.IsNullOrWhiteSpace(Veri) && !Veri.Contains(" "))
                        return true;
                    else
                        return false;
                }
                else
                {
                    if (Veri != "" && !string.IsNullOrEmpty(Veri) && !string.IsNullOrWhiteSpace(Veri))
                        return true;
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}