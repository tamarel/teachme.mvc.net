﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeachMe.Models
{
    public class FakeDB
    {
        static string cat = "אזרחות,אלגברה,אנגלית,ביולוגיה,גיאוגרפיה,הבעה,הוראה מתקנת,היסטוריה,הכנה לכיתה א,הסתברות,חדו\"א,חינוך מיוחד,חשבונאות,כימיה,כלכלה,לשון,מוזיקה,מדעי המחשב,מזרחנות,מנהל עסקים,מקצועות קודש,משפטים,מתמטיקה,סוציולוגיה,סטטיסטיקה,ספרות,עברית,ערבית,פיסיקה,פסיכולוגיה,פסיכומטרי,צילום,קריאה וכתיבה,קרימינולוגיה,תאטרון,תוכנות Office,תקשורת,תנ\"ך";

        public static List<string> Cat
        {
            get { return cat.Replace(' ', '-').Split(',').ToList(); }
        }


        static string cities = "אום אל פחם,אופקים,אור יהודה,אור עקיבא,אורנית,אילת,אלעד,אלפי מנשה,אלקנה,אפרתה,אריאל,אשדוד,אשקלון,באקה-ג'ת,באר שבע,בית אל,בית אריה-עופרים,בית שאן,בית שמש,ביתר עילית,בני ברק,בת ים,גבעת זאב,גבעת שמואל,גבעתיים,דימונה,הוד השרון,הר אדר,הרצליה,חדרה,חולון,חיפה,טבריה,טייבה,טירה,טירת כרמל,טמרה,יבנה,יהוד-מונוסון,יקנעם,ירושלים,כפר יונה,כפר סבא,כפר קאסם,כרמיאל,לוד,מגדל העמק,מודיעין-מכבים-רעות,מודיעין עילית,מעלה אדומים,מעלה אפרים,מעלות-תרשיחא,נהריה,נס ציונה,נצרת,נצרת עילית,נשר,נתיבות,נתניה,סח'נין,עיר הכרמל,עכו,עמנואל,עפולה,ערד,פתח תקווה,צפת,קדומים,קלנסווה,קרית אונו,קרית ארבע,קרית אתא,קרית ביאליק,קרית גת,קרית ים,קרית מוצקין,קרית מלאכי,קרית שמונה,קרני-שומרון,ראש-העין,ראשון-לציון,רהט,רחובות,רמלה,רמת-גן,רמת-השרון,רעננה,שגור,שדרות,שפרעם,תל-אביב";

        public static List<string> Cities
        {
            get { return cities.Replace(' ','-').Split(',').ToList(); }
        }
        
        static string teachersTemp = "מיכל דורון 34 הרצליה כלכלה 100 050-2222222,יוחאי אלון 30 תל-אביב סטטיסטיקה 90 050-3333333,הגר אברמסון 27 תל-אביב אזרחות 80 050-4444444,אופיר קורקוס 28 רמת-גן מתמטיקה 110 050-5555555,ארנסטו זילברשטיין 50 חיפה מתמטיקה 100 050-6666666,נדב זורנו 27 תל-אביב מתמטיקה 100 050-7777777,יאיר לביא 39 תל-אביב מתמטיקה 110 050-8888888,חנן דדון 30 חולון מתמטיקה 130 0509999999,אייל שוהם 34 רמת-גן מדעי-המחשב 120 050-9999999,אייל מור 31 הרצליה כלכלה 90 050-1231231,אילן בלוך 31 רמת-גן מתמטיקה 90 050-1313131,שירי שנפ 40 זכרון-יעקב מוזיקה 110 050-1414141,יהודה זוהר 31 ירושלים מנהל-עסקים 100 050-1515151,אלירן חג'בי 31 קרית-אונו פיסיקה 90 050-1616161,כוכב דר 27 רמת-גן אזרחות 100 050-1717171,נעמה בן-דור 37 רעננה אנגלית 120 050-1919191,כפיר שייר 33 חיפה אנגלית 100 050-1112221,שחר גטניו 31 באר-שבע מדעי-המחשב 90 050-2223331,לידיה מור 35 פתח-תקוה אנגלית 120 050-8885558,יוליה קויפמן 50 חדרה אנגלית 100 050-7979797,ריהאן אורשלב 34 קיסריה אנגלת 90 050-7175784,אורלי אוחנה 25 תל-אביב ביולוגיה 100 050-7159632,רועי אהרון 26 רמת-גן פסיכומטרי 110 050-8256935,אבי בריינאק 37 ירושלים פסיכומטרי 100 050-9494949,איליה אור 34 עפולה מדעי-המחשב 90 050-8256984,אלכס קלמנוביץ' 41 ירושלים חשבונאות 110 050-5554447,אביבה שולמן 25 דימונה מתמטיקה 110 050-6464646,רות עלון 30 חולון מוזיקה 120 050-7123695,טוניו פרס 45 מודיעין חשבונאות 120 050-8369514,איליה סל 25 גבעתיים פיסיקה 90 050-8123695,אדית לומובסקי 55 רחובות אנגלית 130 050-8156934,אריאל אפל 35 בית-שמש צילום 130 050-8175947,אליאב ממן 31 תל-אביב מדעי-המחשב 120 050-8117954,לירן קבילו 30 חיפה לשון 80 050-7369258,צבי נבו 29 ירושלים פסיכומטרי 110 050-8887745,מיכאל גורקוב 33 פתח-תקוה כלכלה 100 050-6663334,דין זוהר 30 הוד-השרון מוזיקה 110 050-7196665,דנה אנגלנדר 36 אילת פיסיקה 80 050-8880005,ראם זלדוב 29 רחובות אנגלית 100 050-7441336,עוז שמש 44 ירושלים מנהל-עסקים 90 050-7089091,אילן טייב 25 אשקלון מוזיקה 80 050-7776665,אסף מנור 30 אשדוד חשבונאות 90 050-6663336,אופיר גרונלנד 39 הרצליה הכנה-לכיתה-א' 70 050-4441587,יוסי נחמיאס 54 הרצליה קריאה-וכתיבה 80 050-7165555,ניק רוז 28 ירושלים אנגלית 90 050-7774982,נתנאל אייל 30 תל-אביב משפטים 90 050-7423333,גיא שקד 45 צפת מדעי-המחשב 100 050-8882225,אליאור כהן 36 ערד מוזיקה 80 050-9197744,עידן בוקאי 27 ראשון-לציון פיסיקה 110 050-6102356,אילון קורן 40 רמת-השרון מדעי-המחשב 100 050-8222222,שפרה בריגה 36 ירושלים מתמטיקה 90 050-3336665,הילה וינברגר 28 ראשון-לציון אזרחות 90 050-8882225,שני אקלר 31 הרצליה לשון 80 052-8282828,לילך בן-יהודה 32 תל-אביב אנגלית 110 054-8800880,רוני מעיין 50 מודיעין צילום 100 052-8883331,אפי יוסף 47 ירושלים מדעי-הנחשב 120 052-8887774,אלירן קדושים 27 רמת-גן כלכלה 80 052-7771111,ערן בלנקי 40 מודיעין אנגלית 80 052-7436952,עידן חן 26 פתח-תקוה מוזיקה 90 050-7156669";

        public static List<Teacher> Teachers
        {
            get 
            {
                List<Teacher> teachers = new List<Teacher>();
                var list = teachersTemp.Replace("  "," ").Split(',').ToList();
                foreach (var t in list)
                {
                    var temp =t.Split(' ');
                    var teacher = new Teacher();
                    teacher.FirstName = temp[0];
                    teacher.LastName = temp[1];
                    teacher.Age = int.Parse(temp[2]);
                    teacher.City = temp[3];
                    teacher.Category = temp[4];
                    teacher.Price = int.Parse(temp[5]);
                    teacher.Phone = temp[6];
                    teachers.Add(teacher);
                }

                return teachers.OrderBy(o=>o.FirstName).ToList(); 
            }
        }
    }
}