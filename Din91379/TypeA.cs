﻿using System.Collections.Generic;

namespace Din91379
{
    public sealed class TypeA : Din91379String
    {
        private static readonly HashSet<string> ValidGlyphs = Glyphs.CreateGlyphSet(new IEnumerable<string>[] {
            Glyphs.LatinLetters.Keys,
            Glyphs.NonLettersN1,
        });

        private TypeA(string value) : base(value)
        {
        }

        public string GetSearchForm()
        {
            return _GetSearchForm();
        }

        public static TypeA FromString(string value)
        {
            value = _ConvertAndCheck(value, ValidGlyphs);
            return new TypeA(value);
        }

        public static bool IsValid(string value)
        {
            return _IsValid(value, ValidGlyphs);
        }

        public static string? GetFirstInvalidGlyph(string value)
        {
            return _GetFirstInvalidGlyph(value, ValidGlyphs);
        }

        public static TypeA operator +(TypeA left, TypeA right)
        {
            return new TypeA(left.value + right.value);
        }
    }
}
