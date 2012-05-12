#region License
/*
MIT License
Copyright © 2006 The Mono.Xna Team

All rights reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
#endregion License

using System;

namespace Microsoft.Xna.Framework
{
    public struct Color : IEquatable<Color>
    {
		// ARGB
        private uint _packedValue;

        #region Constant Values

        public const uint TRANSPARENTBLACK_VALUE = 0;
        public const uint TRANSPARENTWHITE_VALUE = 0xffffff;
        public const uint ALICEBLUE_VALUE = 0xfff0f8ff;
        public const uint ANTIQUEWHITE_VALUE = 0xfffaebd7;
        public const uint AQUA_VALUE = 0xff00ffff;
        public const uint AQUAMARINE_VALUE = 0xff7fffd4;
        public const uint AZURE_VALUE = 0xfff0ffff;
        public const uint BEIGE_VALUE = 0xfff5f5dc;
        public const uint BISQUE_VALUE = 0xffffe4c4;
        public const uint BLACK_VALUE = 0xff000000;
        public const uint BLANCHEDALMOND_VALUE = 0xffffebcd;
        public const uint BLUE_VALUE = 0xff0000ff;
        public const uint BLUEVIOLET_VALUE = 0xff8a2be2;
        public const uint BROWN_VALUE = 0xffa52a2a;
        public const uint BURLYWOOD_VALUE = 0xffdeb887;
        public const uint CADETBLUE_VALUE = 0xff5f9ea0;
        public const uint CHARTREUSE_VALUE = 0xff7fff00;
        public const uint CHOCOLATE_VALUE = 0xffd2691e;
        public const uint CORAL_VALUE = 0xffff7f50;
        public const uint CORNFLOWERBLUE_VALUE = 0xff6495ed;
        public const uint CORNSILK_VALUE = 0xfffff8dc;
        public const uint CRIMSON_VALUE = 0xffdc143c;
        public const uint CYAN_VALUE = 0xff00ffff;
        public const uint DARKBLUE_VALUE = 0xff00008b;
        public const uint DARKCYAN_VALUE = 0xff008b8b;
        public const uint DARKGOLDENROD_VALUE = 0xffb8860b;
        public const uint DARKGRAY_VALUE = 0xffa9a9a9;
        public const uint DARKGREEN_VALUE = 0xff006400;
        public const uint DARKKHAKI_VALUE = 0xffbdb76b;
        public const uint DARKMAGENTA_VALUE = 0xff8b008b;
        public const uint DARKOLIVEGREEN_VALUE = 0xff556b2f;
        public const uint DARKORANGE_VALUE = 0xffff8c00;
        public const uint DARKORCHID_VALUE = 0xff9932cc;
        public const uint DARKRED_VALUE = 0xff8b0000;
        public const uint DARKSALMON_VALUE = 0xffe9967a;
        public const uint DARKSEAGREEN_VALUE = 0xff8fbc8b;
        public const uint DARKSLATEBLUE_VALUE = 0xff483d8b;
        public const uint DARKSLATEGRAY_VALUE = 0xff2f4f4f;
        public const uint DARKTURQUOISE_VALUE = 0xff00ced1;
        public const uint DARKVIOLET_VALUE = 0xff9400d3;
        public const uint DEEPPINK_VALUE = 0xffff1493;
        public const uint DEEPSKYBLUE_VALUE = 0xff00bfff;
        public const uint DIMGRAY_VALUE = 0xff696969;
        public const uint DODGERBLUE_VALUE = 0xff1e90ff;
        public const uint FIREBRICK_VALUE = 0xffb22222;
        public const uint FLORALWHITE_VALUE = 0xfffffaf0;
        public const uint FORESTGREEN_VALUE = 0xff228b22;
        public const uint FUCHSIA_VALUE = 0xffff00ff;
        public const uint GAINSBORO_VALUE = 0xffdcdcdc;
        public const uint GHOSTWHITE_VALUE = 0xfff8f8ff;
        public const uint GOLD_VALUE = 0xffffd700;
        public const uint GOLDENROD_VALUE = 0xffdaa520;
        public const uint GRAY_VALUE = 0xff808080;
        public const uint GREEN_VALUE = 0xff008000;
        public const uint GREENYELLOW_VALUE = 0xffadff2f;
        public const uint HONEYDEW_VALUE = 0xfff0fff0;
        public const uint HOTPINK_VALUE = 0xffff69b4;
        public const uint INDIANRED_VALUE = 0xffcd5c5c;
        public const uint INDIGO_VALUE = 0xff4b0082;
        public const uint IVORY_VALUE = 0xfffffff0;
        public const uint KHAKI_VALUE = 0xfff0e68c;
        public const uint LAVENDER_VALUE = 0xffe6e6fa;
        public const uint LAVENDERBLUSH_VALUE = 0xfffff0f5;
        public const uint LAWNGREEN_VALUE = 0xff7cfc00;
        public const uint LEMONCHIFFON_VALUE = 0xfffffacd;
        public const uint LIGHTBLUE_VALUE = 0xffadd8e6;
        public const uint LIGHTCORAL_VALUE = 0xfff08080;
        public const uint LIGHTCYAN_VALUE = 0xffe0ffff;
        public const uint LIGHTGOLDENRODYELLOW_VALUE = 0xfffafad2;
        public const uint LIGHTGREEN_VALUE = 0xff90ee90;
        public const uint LIGHTGRAY_VALUE = 0xffd3d3d3;
        public const uint LIGHTPINK_VALUE = 0xffffb6c1;
        public const uint LIGHTSALMON_VALUE = 0xffffa07a;
        public const uint LIGHTSEAGREEN_VALUE = 0xff20b2aa;
        public const uint LIGHTSKYBLUE_VALUE = 0xff87cefa;
        public const uint LIGHTSLATEGRAY_VALUE = 0xff778899;
        public const uint LIGHTSTEELBLUE_VALUE = 0xffb0c4de;
        public const uint LIGHTYELLOW_VALUE = 0xffffffe0;
        public const uint LIME_VALUE = 0xff00ff00;
        public const uint LIMEGREEN_VALUE = 0xff32cd32;
        public const uint LINEN_VALUE = 0xfffaf0e6;
        public const uint MAGENTA_VALUE = 0xffff00ff;
        public const uint MAROON_VALUE = 0xff800000;
        public const uint MEDIUMAQUAMARINE_VALUE = 0xff66cdaa;
        public const uint MEDIUMBLUE_VALUE = 0xff0000cd;
        public const uint MEDIUMORCHID_VALUE = 0xffba55d3;
        public const uint MEDIUMPURPLE_VALUE = 0xff9370db;
        public const uint MEDIUMSEAGREEN_VALUE = 0xff3cb371;
        public const uint MEDIUMSLATEBLUE_VALUE = 0xff7b68ee;
        public const uint MEDIUMSPRINGGREEN_VALUE = 0xff00fa9a;
        public const uint MEDIUMTURQUOISE_VALUE = 0xff48d1cc;
        public const uint MEDIUMVIOLETRED_VALUE = 0xffc71585;
        public const uint MIDNIGHTBLUE_VALUE = 0xff191970;
        public const uint MINTCREAM_VALUE = 0xfff5fffa;
        public const uint MISTYROSE_VALUE = 0xffffe4e1;
        public const uint MOCCASIN_VALUE = 0xffffe4b5;
        public const uint NAVAJOWHITE_VALUE = 0xffffdead;
        public const uint NAVY_VALUE = 0xff000080;
        public const uint OLDLACE_VALUE = 0xfffdf5e6;
        public const uint OLIVE_VALUE = 0xff808000;
        public const uint OLIVEDRAB_VALUE = 0xff6b8e23;
        public const uint ORANGE_VALUE = 0xffffa500;
        public const uint ORANGERED_VALUE = 0xffff4500;
        public const uint ORCHID_VALUE = 0xffda70d6;
        public const uint PALEGOLDENROD_VALUE = 0xffeee8aa;
        public const uint PALEGREEN_VALUE = 0xff98fb98;
        public const uint PALETURQUOISE_VALUE = 0xffafeeee;
        public const uint PALEVIOLETRED_VALUE = 0xffdb7093;
        public const uint PAPAYAWHIP_VALUE = 0xffffefd5;
        public const uint PEACHPUFF_VALUE = 0xffffdab9;
        public const uint PERU_VALUE = 0xffcd853f;
        public const uint PINK_VALUE = 0xffffc0cb;
        public const uint PLUM_VALUE = 0xffdda0dd;
        public const uint POWDERBLUE_VALUE = 0xffb0e0e6;
        public const uint PURPLE_VALUE = 0xff800080;
        public const uint RED_VALUE = 0xffff0000;
        public const uint ROSYBROWN_VALUE = 0xffbc8f8f;
        public const uint ROYALBLUE_VALUE = 0xff4169e1;
        public const uint SADDLEBROWN_VALUE = 0xff8b4513;
        public const uint SALMON_VALUE = 0xfffa8072;
        public const uint SANDYBROWN_VALUE = 0xfff4a460;
        public const uint SEAGREEN_VALUE = 0xff2e8b57;
        public const uint SEASHELL_VALUE = 0xfffff5ee;
        public const uint SIENNA_VALUE = 0xffa0522d;
        public const uint SILVER_VALUE = 0xffc0c0c0;
        public const uint SKYBLUE_VALUE = 0xff87ceeb;
        public const uint SLATEBLUE_VALUE = 0xff6a5acd;
        public const uint SLATEGRAY_VALUE = 0xff708090;
        public const uint SNOW_VALUE = 0xfffffafa;
        public const uint SPRINGGREEN_VALUE = 0xff00ff7f;
        public const uint STEELBLUE_VALUE = 0xff4682b4;
        public const uint TAN_VALUE = 0xffd2b48c;
        public const uint TEAL_VALUE = 0xff008080;
        public const uint THISTLE_VALUE = 0xffd8bfd8;
        public const uint TOMATO_VALUE = 0xffff6347;
        public const uint TURQUOISE_VALUE = 0xff40e0d0;
        public const uint VIOLET_VALUE = 0xffee82ee;
        public const uint WHEAT_VALUE = 0xfff5deb3;
        public const uint WHITE_VALUE = uint.MaxValue;
        public const uint WHITESMOKE_VALUE = 0xfff5f5f5;
        public const uint YELLOW_VALUE = 0xffffff00;
        public const uint YELLOWGREEN_VALUE = 0xff9acd32;

        #endregion

        #region Colors by name

        public static readonly Color TransparentBlack = new Color(0);
        public static readonly Color TransparentWhite = new Color(0xffffff);
        public static readonly Color AliceBlue = new Color(0xfff0f8ff);
        public static readonly Color AntiqueWhite = new Color(0xfffaebd7);
        public static readonly Color Aqua = new Color(0xff00ffff);
        public static readonly Color Aquamarine = new Color(0xff7fffd4);
        public static readonly Color Azure = new Color(0xfff0ffff);
        public static readonly Color Beige = new Color(0xfff5f5dc);
        public static readonly Color Bisque = new Color(0xffffe4c4);
        public static readonly Color Black = new Color(0xff000000);
        public static readonly Color BlanchedAlmond = new Color(0xffffebcd);
        public static readonly Color Blue = new Color(0xff0000ff);
        public static readonly Color BlueViolet = new Color(0xff8a2be2);
        public static readonly Color Brown = new Color(0xffa52a2a);
        public static readonly Color BurlyWood = new Color(0xffdeb887);
        public static readonly Color CadetBlue = new Color(0xff5f9ea0);
        public static readonly Color Chartreuse = new Color(0xff7fff00);
        public static readonly Color Chocolate = new Color(0xffd2691e);
        public static readonly Color Coral = new Color(0xffff7f50);
        public static readonly Color CornflowerBlue = new Color(0xff6495ed);
        public static readonly Color Cornsilk = new Color(0xfffff8dc);
        public static readonly Color Crimson = new Color(0xffdc143c);
        public static readonly Color Cyan = new Color(0xff00ffff);
        public static readonly Color DarkBlue = new Color(0xff00008b);
        public static readonly Color DarkCyan = new Color(0xff008b8b);
        public static readonly Color DarkGoldenrod = new Color(0xffb8860b);
        public static readonly Color DarkGray = new Color(0xffa9a9a9);
        public static readonly Color DarkGreen = new Color(0xff006400);
        public static readonly Color DarkKhaki = new Color(0xffbdb76b);
        public static readonly Color DarkMagenta = new Color(0xff8b008b);
        public static readonly Color DarkOliveGreen = new Color(0xff556b2f);
        public static readonly Color DarkOrange = new Color(0xffff8c00);
        public static readonly Color DarkOrchid = new Color(0xff9932cc);
        public static readonly Color DarkRed = new Color(0xff8b0000);
        public static readonly Color DarkSalmon = new Color(0xffe9967a);
        public static readonly Color DarkSeaGreen = new Color(0xff8fbc8b);
        public static readonly Color DarkSlateBlue = new Color(0xff483d8b);
        public static readonly Color DarkSlateGray = new Color(0xff2f4f4f);
        public static readonly Color DarkTurquoise = new Color(0xff00ced1);
        public static readonly Color DarkViolet = new Color(0xff9400d3);
        public static readonly Color DeepPink = new Color(0xffff1493);
        public static readonly Color DeepSkyBlue = new Color(0xff00bfff);
        public static readonly Color DimGray = new Color(0xff696969);
        public static readonly Color DodgerBlue = new Color(0xff1e90ff);
        public static readonly Color Firebrick = new Color(0xffb22222);
        public static readonly Color FloralWhite = new Color(0xfffffaf0);
        public static readonly Color ForestGreen = new Color(0xff228b22);
        public static readonly Color Fuchsia = new Color(0xffff00ff);
        public static readonly Color Gainsboro = new Color(0xffdcdcdc);
        public static readonly Color GhostWhite = new Color(0xfff8f8ff);
        public static readonly Color Gold = new Color(0xffffd700);
        public static readonly Color Goldenrod = new Color(0xffdaa520);
        public static readonly Color Gray = new Color(0xff808080);
        public static readonly Color Green = new Color(0xff008000);
        public static readonly Color GreenYellow = new Color(0xffadff2f);
        public static readonly Color Honeydew = new Color(0xfff0fff0);
        public static readonly Color HotPink = new Color(0xffff69b4);
        public static readonly Color IndianRed = new Color(0xffcd5c5c);
        public static readonly Color Indigo = new Color(0xff4b0082);
        public static readonly Color Ivory = new Color(0xfffffff0);
        public static readonly Color Khaki = new Color(0xfff0e68c);
        public static readonly Color Lavender = new Color(0xffe6e6fa);
        public static readonly Color LavenderBlush = new Color(0xfffff0f5);
        public static readonly Color LawnGreen = new Color(0xff7cfc00);
        public static readonly Color LemonChiffon = new Color(0xfffffacd);
        public static readonly Color LightBlue = new Color(0xffadd8e6);
        public static readonly Color LightCoral = new Color(0xfff08080);
        public static readonly Color LightCyan = new Color(0xffe0ffff);
        public static readonly Color LightGoldenrodYellow = new Color(0xfffafad2);
        public static readonly Color LightGreen = new Color(0xff90ee90);
        public static readonly Color LightGray = new Color(0xffd3d3d3);
        public static readonly Color LightPink = new Color(0xffffb6c1);
        public static readonly Color LightSalmon = new Color(0xffffa07a);
        public static readonly Color LightSeaGreen = new Color(0xff20b2aa);
        public static readonly Color LightSkyBlue = new Color(0xff87cefa);
        public static readonly Color LightSlateGray = new Color(0xff778899);
        public static readonly Color LightSteelBlue = new Color(0xffb0c4de);
        public static readonly Color LightYellow = new Color(0xffffffe0);
        public static readonly Color Lime = new Color(0xff00ff00);
        public static readonly Color LimeGreen = new Color(0xff32cd32);
        public static readonly Color Linen = new Color(0xfffaf0e6);
        public static readonly Color Magenta = new Color(0xffff00ff);
        public static readonly Color Maroon = new Color(0xff800000);
        public static readonly Color MediumAquamarine = new Color(0xff66cdaa);
        public static readonly Color MediumBlue = new Color(0xff0000cd);
        public static readonly Color MediumOrchid = new Color(0xffba55d3);
        public static readonly Color MediumPurple = new Color(0xff9370db);
        public static readonly Color MediumSeaGreen = new Color(0xff3cb371);
        public static readonly Color MediumSlateBlue = new Color(0xff7b68ee);
        public static readonly Color MediumSpringGreen = new Color(0xff00fa9a);
        public static readonly Color MediumTurquoise = new Color(0xff48d1cc);
        public static readonly Color MediumVioletRed = new Color(0xffc71585);
        public static readonly Color MidnightBlue = new Color(0xff191970);
        public static readonly Color MintCream = new Color(0xfff5fffa);
        public static readonly Color MistyRose = new Color(0xffffe4e1);
        public static readonly Color Moccasin = new Color(0xffffe4b5);
        public static readonly Color NavajoWhite = new Color(0xffffdead);
        public static readonly Color Navy = new Color(0xff000080);
        public static readonly Color OldLace = new Color(0xfffdf5e6);
        public static readonly Color Olive = new Color(0xff808000);
        public static readonly Color OliveDrab = new Color(0xff6b8e23);
        public static readonly Color Orange = new Color(0xffffa500);
        public static readonly Color OrangeRed = new Color(0xffff4500);
        public static readonly Color Orchid = new Color(0xffda70d6);
        public static readonly Color PaleGoldenrod = new Color(0xffeee8aa);
        public static readonly Color PaleGreen = new Color(0xff98fb98);
        public static readonly Color PaleTurquoise = new Color(0xffafeeee);
        public static readonly Color PaleVioletRed = new Color(0xffdb7093);
        public static readonly Color PapayaWhip = new Color(0xffffefd5);
        public static readonly Color PeachPuff = new Color(0xffffdab9);
        public static readonly Color Peru = new Color(0xffcd853f);
        public static readonly Color Pink = new Color(0xffffc0cb);
        public static readonly Color Plum = new Color(0xffdda0dd);
        public static readonly Color PowderBlue = new Color(0xffb0e0e6);
        public static readonly Color Purple = new Color(0xff800080);
        public static readonly Color Red = new Color(0xffff0000);
        public static readonly Color RosyBrown = new Color(0xffbc8f8f);
        public static readonly Color RoyalBlue = new Color(0xff4169e1);
        public static readonly Color SaddleBrown = new Color(0xff8b4513);
        public static readonly Color Salmon = new Color(0xfffa8072);
        public static readonly Color SandyBrown = new Color(0xfff4a460);
        public static readonly Color SeaGreen = new Color(0xff2e8b57);
        public static readonly Color SeaShell = new Color(0xfffff5ee);
        public static readonly Color Sienna = new Color(0xffa0522d);
        public static readonly Color Silver = new Color(0xffc0c0c0);
        public static readonly Color SkyBlue = new Color(0xff87ceeb);
        public static readonly Color SlateBlue = new Color(0xff6a5acd);
        public static readonly Color SlateGray = new Color(0xff708090);
        public static readonly Color Snow = new Color(0xfffffafa);
        public static readonly Color SpringGreen = new Color(0xff00ff7f);
        public static readonly Color SteelBlue = new Color(0xff4682b4);
        public static readonly Color Tan = new Color(0xffd2b48c);
        public static readonly Color Teal = new Color(0xff008080);
        public static readonly Color Thistle = new Color(0xffd8bfd8);
        public static readonly Color Tomato = new Color(0xffff6347);
        public static readonly Color Turquoise = new Color(0xff40e0d0);
        public static readonly Color Violet = new Color(0xffee82ee);
        public static readonly Color Wheat = new Color(0xfff5deb3);
        public static readonly Color White = new Color(uint.MaxValue);
        public static readonly Color WhiteSmoke = new Color(0xfff5f5f5);
        public static readonly Color Yellow = new Color(0xffffff00);
        public static readonly Color YellowGreen = new Color(0xff9acd32);
        
        #endregion

        private Color(uint packedValue)
        {
            _packedValue = packedValue;
			// ARGB
			//_packedValue = (packedValue << 8) | ((packedValue & 0xff000000) >> 24);
			// ABGR			
			//_packedValue = (packedValue & 0xff00ff00) | ((packedValue & 0x000000ff) << 16) | ((packedValue & 0x00ff0000) >> 16);
        }

        public Color(Vector4 color)
        {
            _packedValue = 0;
			
			R = (byte)MathHelper.Clamp(color.X * 255, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(color.Y * 255, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(color.Z * 255, Byte.MinValue, Byte.MaxValue);
            A = (byte)MathHelper.Clamp(color.W * 255, Byte.MinValue, Byte.MaxValue);
        }

        public Color(Vector3 color)
        {
            _packedValue = 0;

            R = (byte)MathHelper.Clamp(color.X * 255, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(color.Y * 255, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(color.Z * 255, Byte.MinValue, Byte.MaxValue);
            A = 255;
        }

        public Color(Color color, int alpha)
        {
            _packedValue = 0;

            R = color.R;
            G = color.G;
            B = color.B;
            A = (byte)MathHelper.Clamp(alpha, Byte.MinValue, Byte.MaxValue);
        }

        public Color(Color color, float alpha)
        {
            _packedValue = 0;

            R = color.R;
            G = color.G;
            B = color.B;
            A = (byte)MathHelper.Clamp(alpha * 255, Byte.MinValue, Byte.MaxValue);
        }

        public Color(float r, float g, float b)
        {
            _packedValue = 0;
			
            R = (byte)MathHelper.Clamp(r * 255, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(g * 255, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(b * 255, Byte.MinValue, Byte.MaxValue);
            A = 255;
        }

        public Color(int r, int g, int b)
        {
            _packedValue = 0;
            R = (byte)MathHelper.Clamp(r, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(g, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(b, Byte.MinValue, Byte.MaxValue);
            A = (byte)255;
        }


        public Color(int r, int g, int b, int alpha)
        {
            _packedValue = 0;
            R = (byte)MathHelper.Clamp(r, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(g, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(b, Byte.MinValue, Byte.MaxValue);
            A = (byte)MathHelper.Clamp(alpha, Byte.MinValue, Byte.MaxValue);
        }

        public Color(float r, float g, float b, float alpha)
        {
            _packedValue = 0;
			
            R = (byte)MathHelper.Clamp(r * 255, Byte.MinValue, Byte.MaxValue);
            G = (byte)MathHelper.Clamp(g * 255, Byte.MinValue, Byte.MaxValue);
            B = (byte)MathHelper.Clamp(b * 255, Byte.MinValue, Byte.MaxValue);
            A = (byte)MathHelper.Clamp(alpha * 255, Byte.MinValue, Byte.MaxValue);
        }

        public byte B
        {
            get
            {
                return (byte)this._packedValue;
            }
            set
            {
                this._packedValue = (this._packedValue & 0xffffff00) | value;
            }
        }

        public byte G
        {
            get
            {
                return (byte)(this._packedValue >> 8);
            }
            set
            {
                this._packedValue = (this._packedValue & 0xffff00ff) | ((uint)(value << 8));
            }
        }
        public byte R
        {
            get
            {
                return (byte)(this._packedValue >> 16);
            }
            set
            {
                this._packedValue = (this._packedValue & 0xff00ffff) | ((uint)(value << 16 ));
            }
        }
        public byte A
        {
            get
            {
                return (byte)(this._packedValue >> 24);
            }
            set
            {
                this._packedValue = (this._packedValue & 0x00ffffff) | ((uint)(value << 24));
            }
        }
		
		public uint GLPackedValue
		{
			get { return (_packedValue & 0xff00ff00) | ((_packedValue & 0x000000ff) << 16) | ((_packedValue & 0x00ff0000) >> 16); }  
		}
		
		
        public static bool operator ==(Color a, Color b)
        {
            return (a.A == b.A &&
                a.R == b.R &&
                a.G == b.G &&
                a.B == b.B);
        }

        public static bool operator !=(Color a, Color b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return this._packedValue.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return ((obj is Color) && this.Equals((Color)obj));
        }


		public static Color Transparent
		{
			get{
				return new Color(0);
			}
		}
       

        public static Color Lerp(Color value1, Color value2, Single amount)
        {
            byte Red   = (byte)MathHelper.Clamp(MathHelper.Lerp(value1.R, value2.R, amount), Byte.MinValue, Byte.MaxValue);   
			byte Green = (byte)MathHelper.Clamp(MathHelper.Lerp(value1.G, value2.G, amount), Byte.MinValue, Byte.MaxValue);
			byte Blue  = (byte)MathHelper.Clamp(MathHelper.Lerp(value1.B, value2.B, amount), Byte.MinValue, Byte.MaxValue);
			byte Alpha = (byte)MathHelper.Clamp(MathHelper.Lerp(value1.A, value2.A, amount), Byte.MinValue, Byte.MaxValue);
			
            return new Color( Red, Green, Blue, Alpha );
        }
		
		public static Color Multiply( Color value, float scale)
		{
			byte Red = (byte)(value.R * scale);
			byte Green = (byte)(value.G * scale);
			byte Blue = (byte)(value.B * scale);
			byte Alpha = (byte)(value.A * scale);
			
			return new Color( Red, Green, Blue, Alpha );
		}
		
		public static Color operator *(Color value, float scale)
        {
            return Multiply(value, scale);
        }		

        public Vector3 ToVector3()
        {
            return new Vector3(R / 255.0f, G / 255.0f, B / 255.0f);
        }

        public Vector4 ToVector4()
        {
            return new Vector4(R / 255.0f, G / 255.0f, B / 255.0f, A / 255.0f);
        }

        public UInt32 PackedValue
        {
            get { return _packedValue; }
            set { _packedValue = value; }
        }
		
		public override string ToString ()
		{
			return string.Format("[Color: R={0}, G={1}, B={2}, A={3}, PackedValue={4}]", R, G, B, A, PackedValue);
		}

        public static Color FromNonPremultiplied(Vector4 vector)
        {
            return new Color(vector.X * vector.W, vector.Y * vector.W, vector.Z * vector.W, vector.W);
        }

        public static Color FromNonPremultiplied(int r, int g, int b, int a)
        {
            return new Color((byte)(r * a / 255),(byte)(g * a / 255), (byte)(b * a / 255), a);
        }

        #region IEquatable<Color> Members

        public bool Equals(Color other)
        {
			return this.GLPackedValue == other.GLPackedValue;
        }

        #endregion
    }
}
