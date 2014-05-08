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
            get { return cities.Replace(' ', '-').Split(',').ToList(); }
        }

        static string teachersTemp = "מיכל דורון 34 תל-אביב קשולני 7 מדעי-המחשב 100 050-2222222,יוחאי אלון 30 תל-אביב מינץ 22 מדעי-המחשב 90 050-3333333,הגר אברמסון 27 תל-אביב ברודצקי 2 מדעי-המחשב 80 050-4444444,אופיר קורקוס 28 רמת-גן טרומן 20 מתמטיקה 110 050-5555555,ארנסטו זילברשטיין 50 רמת-גן דרך:נגבה 61 מתמטיקה 100 050-6666666,נדב זורנו 27 תל-אביב דרך:ההגנה 136 מדעי-המחשב 100 050-7777777,יאיר לביא 39 תל-אביב מרק 16 מדעי-המחשב 110 050-8888888,חנן דדון 30 רמת-גן תפארת:ישראל 6 מתמטיקה 130 0509999999,אייל שוהם 34 רמת-גן תל:חי 27 מתמטיקה 120 050-9999999,אייל מור 31 ירושלים קרן:היסוד 25 מוזיקה 90 050-1231231,אילן בלוך 31 רמת-גן דבורה:הנביאה 11 מתמטיקה 90 050-1313131,שירי שנפ 40 ירושלים התומר 4 מוזיקה 110 050-1414141,יהודה זוהר 31 ירושלים בוסתנאי 11 מוזיקה 100 050-1515151,אלירן חג'בי 31 ירושלים רפפורט 33 מוזיקה 90 050-1616161,כוכב דר 27 רמת-גן שלומציון 13 מתמטיקה 100 050-1717171,נעמה בן-דור 37 תל-אביב רוממה 36 אנגלית 120 050-1919191,כפיר שייר 33 רמת-גן עוזיאל 93 מתמטיקה 100 050-1112221,שחר גטניו 31 ירושלים ורדינון 13 מוזיקה 90 050-2223331,לידיה מור 35 תל-אביב הלסינקי 6 אנגלית 120 050-8885558,יוליה קויפמן 50 ירושלים אגריפס 171 מוזיקה 100 050-7979797,ריהאן אורשלב 34 רמת-גן שיקמה 6 מתמטיקה 90 050-7175784,אורלי אוחנה 25 תל-אביב פנקס 54 מדעי-המחשב 100 050-7159632,רועי אהרון 26 רמת-גן דרך:נגבה 10 מתמטיקה 110 050-8256935,אבי בריינאק 37 ירושלים הארזים 19 מוזיקה 100 050-9494949,איליה אור 34 תל-אביב מאנה 4 מדעי-המחשב 90 050-8256984,אלכס קלמנוביץ' 41 ירושלים התומר 4 מוזיקה 110 050-5554447,אביבה שולמן 25 רמת-גן טרומן 17 מתמטיקה 110 050-6464646,רות עלון 30 ירושלים דן 20 מוזיקה 120 050-7123695,טוניו פרס 45 ירושלים נרקיס 38 מוזיקה 120 050-8369514,איליה סל 25 רמת-גן סמדר 48 כלכלה 90 050-8123695,אדית לומובסקי 55 ירושלים נעמי 11 מוזיקה 130 050-8156934,אריאל אפל 35 ירושלים אנטיגנוס 1 מוזיקה 130 050-8175947,אליאב ממן 31 תל-אביב התבור 7 מדעי-המחשב 120 050-8117954,לירן קבילו 30 חיפה האשל 57 פסיכומטרי 80 050-7369258,צבי נבו 29 ירושלים הנביאים 5 מוזיקה 110 050-8887745,מיכאל גורקוב 33 חיפה ויתקין 11 פסיכומטרי 100 050-6663334,דין זוהר 30 ירושלים הגננת 218 מוזיקה 110 050-7196665,דנה אנגלנדר 36 חיפה רות 18 פסיכומטרי 80 050-8880005,ראם זלדוב 29 חיפה איטליה 20 פסיכומטרי 100 050-7441336,עוז שמש 44 ירושלים גולומב 106 מוזיקה 90 050-7089091,אילן טייב 25 ירושלים הרב:בלוי 4 מוזיקה 80 050-7776665,אסף מנור 30 חיפה בירם 1 פסיכומטרי 90 050-6663336,אופיר גרונלנד 39 תל-אביב הסבוראים 19 אנגלית 70 050-4441587,יוסי נחמיאס 54 רמת-גן לויטה 18 כלכלה 80 050-7165555,ניק רוז 28 ירושלים שטראוס 10 מוזיקה 90 050-7774982,נתנאל אייל 30 תל-אביב גוש:עציון 27 אנגלית 90 050-7423333,גיא שקד 45 תל-אביב ענתות 34 מדעי-המחשב 100 050-8882225,אליאור כהן 36 ירושלים הנביאים 19 מוזיקה 80 050-9197744,עידן בוקאי 27 חיפה אורן 31 פסיכומטרי 110 050-6102356,אילון קורן 40 תל-אביב שמעון:רוקח 9 אנגלית 100 050-8222222,שפרה בריגה 36 ירושלים קדימה 67 מוזיקה 90 050-3336665,הילה וינברגר 28 תל-אביב התבור 9 מדעי-המחשב 90 050-8882225,שני אקלר 31 רמת-גן כרמלי 21 מתמטיקה 80 052-8282828,לילך בן-יהודה 32 תל-אביב ביצרון 12 אנגלית 110 054-8800880,רוני מעיין 50 חיפה הרופא 58 פסיכומטרי 100 052-8883331,אפי יוסף 47 ירושלים יפו 217 מוזיקה 120 052-8887774,אלירן קדושים 27 רמת-גן הגלגל 55 כלכלה 80 052-7771111,ערן בלנקי 40 תל-אביב טירת:צבי 6 אנגלית 80 052-7436952,עידן חן 26 תל-אביב בושם 17 מדעי-המחשב 90 050-7156669";

        public static List<Teacher> Teachers
        {
            get
            {
                List<Teacher> teachers = new List<Teacher>();
                var list = teachersTemp.Replace("  ", " ").Split(',').ToList();
                int id = 0;
                foreach (var t in list)
                {
                    var temp = t.Split(' ');
                    var teacher = new Teacher();
                    teacher.User = new ApplicationUser();
                    teacher.User.FirstName = temp[0];
                    teacher.User.LastName = temp[1];
                    teacher.Age = int.Parse(temp[2]);
                    teacher.City = temp[3];
                    teacher.Street = temp[4];
                    teacher.HomeNum = int.Parse(temp[5]);
                    teacher.Category = temp[6];
                    teacher.LessonPrice = int.Parse(temp[7]);
                    teacher.Phone = temp[8];
                    teacher.UserId = (id++).ToString();
                    teachers.Add(teacher);

                }

                return teachers.OrderBy(o => o.User.FirstName).ToList();
            }
        }
    }
}