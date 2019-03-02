using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarTestRules
{
    enum Figure                                         // перечисление возможных фигур
    {
        none,

        southSpy = 'S',                             // лазутчик
        southArcher = 'A',                          // лучник
        southLance = 'L',                           // копейщик
        southSword = 'W',                           // мечник
        southRider = 'R',                           // всадник
        southCatapult = 'C',                        // камнемет

        northSpy = 's',
        northArcher = 'a',
        northLance = 'l',
        northSword = 'w',
        northRider = 'r',
        northCatapult = 'c'
    }

    static class FigureMethods
    {
        public static Color GetColor(this Figure figure)                       // реализуем установку цвета для фигуры
        {
            if (figure == Figure.none)                                 // если фигура "никакая", то и цвет ее никакой.
                return Color.none;

            switch (figure)
            {
                case Figure.southSpy:
                case Figure.southArcher:
                case Figure.southLance:
                case Figure.southSword:
                case Figure.southRider:
                case Figure.southCatapult:
                    return Color.green;

                case Figure.northSpy:
                case Figure.northArcher:
                case Figure.northLance:
                case Figure.northSword:
                case Figure.northRider:
                case Figure.northCatapult:
                    return Color.blue;

                default:
                    return Color.none;
            }
        }
    }
}