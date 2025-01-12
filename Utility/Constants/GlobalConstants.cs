using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Constants
{
    public static class GlobalConstants
    {
        public static string USERNAME_MUST_NOT_EMPTY_MESSAGE = "Kullanıcı adı boş olamaz";
        public static string USERPASSWORD_MUST_NOT_EMPTY_MESSAGE = "Kullanıcı şifresi boş olamaz";
        public static string WRONG_USERNAME_OR_PASSOWRD = "Kullanıcı adı veya şifre hatalı";
        public static string PRODUCT_IS_NOT_FOUND_MESSAGE = "Ürün bulunamadı.";
        public static string PRODUCT_ID_IS_NOT_NUMERIC_MESSAGE = "Ürün Kodu bir sayı olmalı !";
        public static string PRODUCT_FIRST_STOCK_QUANTITY_IS_NOT_NUMERIC_MESSAGE = "İlk stok miktari bir sayı olmalı!";
        public static string PRODUCT_SALES_PRICE_IS_NOT_NUMERIC_MESSAGE = "ürün satış fiyatı bir sayı olmalı!";
        public static string PRODUCT_PURCHASE_PRICE_IS_NOT_NUMERIC_MESSAGE = "ürün alış fiyatı bir sayı olmalı!";
    }
}
