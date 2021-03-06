﻿namespace BitcoinABC.Internal.Secp256K1
{
    internal class Field
    {
        public static bool Equal(Fe a, Fe b)
        {
            var r = new Fe();
            Field.Negate(r, a, 1U);
            Field.Add(r, b);
            return Field.NormalizesToZero(r);
        }

        public static bool EqualVar(Fe a, Fe b)
        {
            var r = new Fe();
            Field.Negate(r, a, 1U);
            Field.Add(r, b);
            return Field.NormalizesToZeroVar(r);
        }

        public static bool Sqrt(Fe r, Fe a)
        {
            var fe1 = new Fe();
            Field.Sqr(fe1, a);
            Field.Mul(fe1, fe1, a);
            var fe2 = new Fe();
            Field.Sqr(fe2, fe1);
            Field.Mul(fe2, fe2, a);
            var fe3 = fe2.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe3, fe3);
            Field.Mul(fe3, fe3, fe2);
            var fe4 = fe3.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe4, fe4);
            Field.Mul(fe4, fe4, fe2);
            var fe5 = fe4.Clone();
            for (var index = 0; index < 2; ++index)
                Field.Sqr(fe5, fe5);
            Field.Mul(fe5, fe5, fe1);
            var fe6 = fe5.Clone();
            for (var index = 0; index < 11; ++index)
                Field.Sqr(fe6, fe6);
            Field.Mul(fe6, fe6, fe5);
            var fe7 = fe6.Clone();
            for (var index = 0; index < 22; ++index)
                Field.Sqr(fe7, fe7);
            Field.Mul(fe7, fe7, fe6);
            var fe8 = fe7.Clone();
            for (var index = 0; index < 44; ++index)
                Field.Sqr(fe8, fe8);
            Field.Mul(fe8, fe8, fe7);
            var fe9 = fe8.Clone();
            for (var index = 0; index < 88; ++index)
                Field.Sqr(fe9, fe9);
            Field.Mul(fe9, fe9, fe8);
            var fe10 = fe9.Clone();
            for (var index = 0; index < 44; ++index)
                Field.Sqr(fe10, fe10);
            Field.Mul(fe10, fe10, fe7);
            var fe11 = fe10.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe11, fe11);
            Field.Mul(fe11, fe11, fe2);
            var fe12 = fe11.Clone();
            for (var index = 0; index < 23; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(fe12, fe12, fe6);
            for (var index = 0; index < 6; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(fe12, fe12, fe1);
            Field.Sqr(fe12, fe12);
            Field.Sqr(r, fe12);
            Field.Sqr(fe12, r);
            return Field.Equal(fe12, a);
        }

        public static void Inv(Fe r, Fe a)
        {
            var fe1 = new Fe();
            Field.Sqr(fe1, a);
            Field.Mul(fe1, fe1, a);
            var fe2 = new Fe();
            Field.Sqr(fe2, fe1);
            Field.Mul(fe2, fe2, a);
            var fe3 = fe2.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe3, fe3);
            Field.Mul(fe3, fe3, fe2);
            var fe4 = fe3.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe4, fe4);
            Field.Mul(fe4, fe4, fe2);
            var fe5 = fe4.Clone();
            for (var index = 0; index < 2; ++index)
                Field.Sqr(fe5, fe5);
            Field.Mul(fe5, fe5, fe1);
            var fe6 = fe5.Clone();
            for (var index = 0; index < 11; ++index)
                Field.Sqr(fe6, fe6);
            Field.Mul(fe6, fe6, fe5);
            var fe7 = fe6.Clone();
            for (var index = 0; index < 22; ++index)
                Field.Sqr(fe7, fe7);
            Field.Mul(fe7, fe7, fe6);
            var fe8 = fe7.Clone();
            for (var index = 0; index < 44; ++index)
                Field.Sqr(fe8, fe8);
            Field.Mul(fe8, fe8, fe7);
            var fe9 = fe8.Clone();
            for (var index = 0; index < 88; ++index)
                Field.Sqr(fe9, fe9);
            Field.Mul(fe9, fe9, fe8);
            var fe10 = fe9.Clone();
            for (var index = 0; index < 44; ++index)
                Field.Sqr(fe10, fe10);
            Field.Mul(fe10, fe10, fe7);
            var fe11 = fe10.Clone();
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe11, fe11);
            Field.Mul(fe11, fe11, fe2);
            var fe12 = fe11.Clone();
            for (var index = 0; index < 23; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(fe12, fe12, fe6);
            for (var index = 0; index < 5; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(fe12, fe12, a);
            for (var index = 0; index < 3; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(fe12, fe12, fe1);
            for (var index = 0; index < 2; ++index)
                Field.Sqr(fe12, fe12);
            Field.Mul(r, a, fe12);
        }

        public static void InvVar(Fe r, Fe a)
        {
            Field.Inv(r, a);
        }

        public static void InvAllVar(Fe[] r, Fe[] a, int len)
        {
            if (len < 1)
                return;
            for (var index = 0; index < len; ++index)
                r[index] = a[index].Clone();
            var index1 = 0;
            while (++index1 < len)
                Field.Mul(r[index1], r[index1 - 1], a[index1]);
            var fe = new Fe();
            int index2;
            Field.InvVar(fe, r[index2 = index1 - 1]);
            while (index2 > 0)
            {
                var index3 = index2--;
                Field.Mul(r[index3], r[index2], fe);
                Field.Mul(fe, fe, a[index3]);
            }
            r[0] = fe.Clone();
        }

        public static void Normalize(Fe r)
        {
            var num1 = r.N[0];
            var num2 = r.N[1];
            var num3 = r.N[2];
            var num4 = r.N[3];
            var num5 = r.N[4];
            var num6 = r.N[5];
            var num7 = r.N[6];
            var num8 = r.N[7];
            var num9 = r.N[8];
            var num10 = r.N[9];
            var num11 = num10 >> 22;
            var num12 = num10 & 4194303U;
            var num13 = num1 + num11 * 977U;
            var num14 = num2 + (num11 << 6) + (num13 >> 26);
            var num15 = num13 & 67108863U;
            var num16 = num3 + (num14 >> 26);
            var num17 = num14 & 67108863U;
            var num18 = num4 + (num16 >> 26);
            var num19 = num16 & 67108863U;
            var num20 = num19;
            var num21 = num5 + (num18 >> 26);
            var num22 = num18 & 67108863U;
            var num23 = num20 & num22;
            var num24 = num6 + (num21 >> 26);
            var num25 = num21 & 67108863U;
            var num26 = num23 & num25;
            var num27 = num7 + (num24 >> 26);
            var num28 = num24 & 67108863U;
            var num29 = num26 & num28;
            var num30 = num8 + (num27 >> 26);
            var num31 = num27 & 67108863U;
            var num32 = num29 & num31;
            var num33 = num9 + (num30 >> 26);
            var num34 = num30 & 67108863U;
            var num35 = num32 & num34;
            var num36 = num12 + (num33 >> 26);
            var num37 = num33 & 67108863U;
            var num38 = num35 & num37;
            var num39 = !((int)num36 == 4194303 & (int)num38 == 67108863) || num17 + 64U + (num15 + 977U >> 26) <= 67108863U ? num36 >> 22 | 0U : num36 >> 22 | 1U;
            var num40 = num15 + num39 * 977U;
            var num41 = num17 + (num39 << 6) + (num40 >> 26);
            var num42 = num40 & 67108863U;
            var num43 = num19 + (num41 >> 26);
            var num44 = num41 & 67108863U;
            var num45 = num22 + (num43 >> 26);
            var num46 = num43 & 67108863U;
            var num47 = num25 + (num45 >> 26);
            var num48 = num45 & 67108863U;
            var num49 = num28 + (num47 >> 26);
            var num50 = num47 & 67108863U;
            var num51 = num31 + (num49 >> 26);
            var num52 = num49 & 67108863U;
            var num53 = num34 + (num51 >> 26);
            var num54 = num51 & 67108863U;
            var num55 = num37 + (num53 >> 26);
            var num56 = num53 & 67108863U;
            var num57 = num36 + (num55 >> 26);
            var num58 = num55 & 67108863U;
            var num59 = num57 & 4194303U;
            r.N[0] = num42;
            r.N[1] = num44;
            r.N[2] = num46;
            r.N[3] = num48;
            r.N[4] = num50;
            r.N[5] = num52;
            r.N[6] = num54;
            r.N[7] = num56;
            r.N[8] = num58;
            r.N[9] = num59;
        }

        public static void NormalizeWeak(Fe r)
        {
            var num1 = r.N[0];
            var num2 = r.N[1];
            var num3 = r.N[2];
            var num4 = r.N[3];
            var num5 = r.N[4];
            var num6 = r.N[5];
            var num7 = r.N[6];
            var num8 = r.N[7];
            var num9 = r.N[8];
            var num10 = r.N[9];
            var num11 = num10 >> 22;
            var num12 = num10 & 4194303U;
            var num13 = num1 + num11 * 977U;
            var num14 = num2 + (num11 << 6) + (num13 >> 26);
            var num15 = num13 & 67108863U;
            var num16 = num3 + (num14 >> 26);
            var num17 = num14 & 67108863U;
            var num18 = num4 + (num16 >> 26);
            var num19 = num16 & 67108863U;
            var num20 = num5 + (num18 >> 26);
            var num21 = num18 & 67108863U;
            var num22 = num6 + (num20 >> 26);
            var num23 = num20 & 67108863U;
            var num24 = num7 + (num22 >> 26);
            var num25 = num22 & 67108863U;
            var num26 = num8 + (num24 >> 26);
            var num27 = num24 & 67108863U;
            var num28 = num9 + (num26 >> 26);
            var num29 = num26 & 67108863U;
            var num30 = num12 + (num28 >> 26);
            var num31 = num28 & 67108863U;
            r.N[0] = num15;
            r.N[1] = num17;
            r.N[2] = num19;
            r.N[3] = num21;
            r.N[4] = num23;
            r.N[5] = num25;
            r.N[6] = num27;
            r.N[7] = num29;
            r.N[8] = num31;
            r.N[9] = num30;
        }

        public static void NormalizeVar(Fe r)
        {
            var num1 = r.N[0];
            var num2 = r.N[1];
            var num3 = r.N[2];
            var num4 = r.N[3];
            var num5 = r.N[4];
            var num6 = r.N[5];
            var num7 = r.N[6];
            var num8 = r.N[7];
            var num9 = r.N[8];
            var num10 = r.N[9];
            var num11 = num10 >> 22;
            var num12 = num10 & 4194303U;
            var num13 = num1 + num11 * 977U;
            var num14 = num2 + (num11 << 6) + (num13 >> 26);
            var num15 = num13 & 67108863U;
            var num16 = num3 + (num14 >> 26);
            var num17 = num14 & 67108863U;
            var num18 = num4 + (num16 >> 26);
            var num19 = num16 & 67108863U;
            var num20 = num19;
            var num21 = num5 + (num18 >> 26);
            var num22 = num18 & 67108863U;
            var num23 = num20 & num22;
            var num24 = num6 + (num21 >> 26);
            var num25 = num21 & 67108863U;
            var num26 = num23 & num25;
            var num27 = num7 + (num24 >> 26);
            var num28 = num24 & 67108863U;
            var num29 = num26 & num28;
            var num30 = num8 + (num27 >> 26);
            var num31 = num27 & 67108863U;
            var num32 = num29 & num31;
            var num33 = num9 + (num30 >> 26);
            var num34 = num30 & 67108863U;
            var num35 = num32 & num34;
            var num36 = num12 + (num33 >> 26);
            var num37 = num33 & 67108863U;
            var num38 = num35 & num37;
            var num39 = (int)num36 != 4194303 || (int)num38 != 67108863 || num17 + 64U + (num15 + 977U >> 26) <= 67108863U ? num36 >> 22 | 0U : num36 >> 22 | 1U;
            if (num39 > 0U)
            {
                var num40 = num15 + 977U;
                var num41 = num17 + (num39 << 6) + (num40 >> 26);
                num15 = num40 & 67108863U;
                var num42 = num19 + (num41 >> 26);
                num17 = num41 & 67108863U;
                var num43 = num22 + (num42 >> 26);
                num19 = num42 & 67108863U;
                var num44 = num25 + (num43 >> 26);
                num22 = num43 & 67108863U;
                var num45 = num28 + (num44 >> 26);
                num25 = num44 & 67108863U;
                var num46 = num31 + (num45 >> 26);
                num28 = num45 & 67108863U;
                var num47 = num34 + (num46 >> 26);
                num31 = num46 & 67108863U;
                var num48 = num37 + (num47 >> 26);
                num34 = num47 & 67108863U;
                var num49 = num36 + (num48 >> 26);
                num37 = num48 & 67108863U;
                num36 = num49 & 4194303U;
            }
            r.N[0] = num15;
            r.N[1] = num17;
            r.N[2] = num19;
            r.N[3] = num22;
            r.N[4] = num25;
            r.N[5] = num28;
            r.N[6] = num31;
            r.N[7] = num34;
            r.N[8] = num37;
            r.N[9] = num36;
        }

        public static bool NormalizesToZero(Fe r)
        {
            var num1 = r.N[0];
            var num2 = r.N[1];
            var num3 = r.N[2];
            var num4 = r.N[3];
            var num5 = r.N[4];
            var num6 = r.N[5];
            var num7 = r.N[6];
            var num8 = r.N[7];
            var num9 = r.N[8];
            var num10 = r.N[9];
            var num11 = num10 >> 22;
            var num12 = num10 & 4194303U;
            var num13 = num1 + num11 * 977U;
            var num14 = num2 + (num11 << 6) + (num13 >> 26);
            var num15 = num13 & 67108863U;
            var num16 = (int)num15;
            var num17 = num15 ^ 976U;
            var num18 = num3 + (num14 >> 26);
            var num19 = num14 & 67108863U;
            var num20 = (int)num19;
            var num21 = num16 | num20;
            var num22 = num17 & (num19 ^ 64U);
            var num23 = num4 + (num18 >> 26);
            var num24 = num18 & 67108863U;
            var num25 = (int)num24;
            var num26 = num21 | num25;
            var num27 = num22 & num24;
            var num28 = num5 + (num23 >> 26);
            var num29 = num23 & 67108863U;
            var num30 = (int)num29;
            var num31 = num26 | num30;
            var num32 = num27 & num29;
            var num33 = num6 + (num28 >> 26);
            var num34 = num28 & 67108863U;
            var num35 = (int)num34;
            var num36 = num31 | num35;
            var num37 = num32 & num34;
            var num38 = num7 + (num33 >> 26);
            var num39 = num33 & 67108863U;
            var num40 = (int)num39;
            var num41 = num36 | num40;
            var num42 = num37 & num39;
            var num43 = num8 + (num38 >> 26);
            var num44 = num38 & 67108863U;
            var num45 = (int)num44;
            var num46 = num41 | num45;
            var num47 = num42 & num44;
            var num48 = num9 + (num43 >> 26);
            var num49 = num43 & 67108863U;
            var num50 = (int)num49;
            var num51 = num46 | num50;
            var num52 = num47 & num49;
            var num53 = num12 + (num48 >> 26);
            var num54 = num48 & 67108863U;
            var num55 = (int)num54;
            var num56 = num51 | num55;
            var num57 = num52 & num54;
            var num58 = (int)num53;
            var num59 = num56 | num58;
            var num60 = num57 & (num53 ^ 62914560U);
            if (num59 != 0)
                return (int)num60 == 67108863;
            return true;
        }

        public static bool NormalizesToZeroVar(Fe r)
        {
            var num1 = r.N[0];
            var num2 = r.N[9];
            var num3 = num2 >> 22;
            var num4 = num1 + num3 * 977U;
            var num5 = num4 & 67108863U;
            var num6 = num5 ^ 976U;
            if (num5 > 0U & (int)num6 != 67108863)
                return false;
            var num7 = r.N[1];
            var num8 = r.N[2];
            var num9 = r.N[3];
            var num10 = r.N[4];
            var num11 = r.N[5];
            var num12 = r.N[6];
            var num13 = r.N[7];
            var num14 = r.N[8];
            var num15 = num2 & 4194303U;
            var num16 = num7 + (num3 << 6) + (num4 >> 26);
            var num17 = num8 + (num16 >> 26);
            var num18 = num16 & 67108863U;
            var num19 = num5 | num18;
            var num20 = num6 & (num18 ^ 64U);
            var num21 = num9 + (num17 >> 26);
            var num22 = num17 & 67108863U;
            var num23 = num19 | num22;
            var num24 = num20 & num22;
            var num25 = num10 + (num21 >> 26);
            var num26 = num21 & 67108863U;
            var num27 = num23 | num26;
            var num28 = num24 & num26;
            var num29 = num11 + (num25 >> 26);
            var num30 = num25 & 67108863U;
            var num31 = num27 | num30;
            var num32 = num28 & num30;
            var num33 = num12 + (num29 >> 26);
            var num34 = num29 & 67108863U;
            var num35 = num31 | num34;
            var num36 = num32 & num34;
            var num37 = num13 + (num33 >> 26);
            var num38 = num33 & 67108863U;
            var num39 = num35 | num38;
            var num40 = num36 & num38;
            var num41 = num14 + (num37 >> 26);
            var num42 = num37 & 67108863U;
            var num43 = num39 | num42;
            var num44 = num40 & num42;
            var num45 = num15 + (num41 >> 26);
            var num46 = num41 & 67108863U;
            var num47 = num43 | num46;
            var num48 = num44 & num46;
            return (int)(num47 | num45) == 0 | (int)(num48 & (num45 ^ 62914560U)) == 67108863;
        }

        public static void SetInt(Fe r, uint a)
        {
            r.N[0] = a;
            r.N[1] = r.N[2] = r.N[3] = r.N[4] = r.N[5] = r.N[6] = r.N[7] = r.N[8] = r.N[9] = 0U;
        }

        public static bool IsZero(Fe a)
        {
            var n = a.N;
            return ((int)n[0] | (int)n[1] | (int)n[2] | (int)n[3] | (int)n[4] | (int)n[5] | (int)n[6] | (int)n[7] | (int)n[8] | (int)n[9]) == 0;
        }

        public static bool IsOdd(Fe a)
        {
            return (a.N[0] & 1U) > 0U;
        }

        public static void Clear(Fe a)
        {
            for (var index = 0; index < 10; ++index)
                a.N[index] = 0U;
        }

        public static bool SetB32(Fe r, byte[] a)
        {
            r.N[0] = (uint)((int)a[31] | (int)a[30] << 8 | (int)a[29] << 16 | ((int)a[28] & 3) << 24);
            r.N[1] = (uint)((int)a[28] >> 2 & 63 | (int)a[27] << 6 | (int)a[26] << 14 | ((int)a[25] & 15) << 22);
            r.N[2] = (uint)((int)a[25] >> 4 & 15 | (int)a[24] << 4 | (int)a[23] << 12 | ((int)a[22] & 63) << 20);
            r.N[3] = (uint)((int)a[22] >> 6 & 3 | (int)a[21] << 2 | (int)a[20] << 10 | (int)a[19] << 18);
            r.N[4] = (uint)((int)a[18] | (int)a[17] << 8 | (int)a[16] << 16 | ((int)a[15] & 3) << 24);
            r.N[5] = (uint)((int)a[15] >> 2 & 63 | (int)a[14] << 6 | (int)a[13] << 14 | ((int)a[12] & 15) << 22);
            r.N[6] = (uint)((int)a[12] >> 4 & 15 | (int)a[11] << 4 | (int)a[10] << 12 | ((int)a[9] & 63) << 20);
            r.N[7] = (uint)((int)a[9] >> 6 & 3 | (int)a[8] << 2 | (int)a[7] << 10 | (int)a[6] << 18);
            r.N[8] = (uint)((int)a[5] | (int)a[4] << 8 | (int)a[3] << 16 | ((int)a[2] & 3) << 24);
            r.N[9] = (uint)((int)a[2] >> 2 & 63 | (int)a[1] << 6 | (int)a[0] << 14);
            return (int)r.N[9] != 4194303 || ((int)r.N[8] & (int)r.N[7] & (int)r.N[6] & (int)r.N[5] & (int)r.N[4] & (int)r.N[3] & (int)r.N[2]) != 67108863 || r.N[1] + 64U + (r.N[0] + 977U >> 26) <= 67108863U;
        }

        public static bool SetB32(Fe r, byte[] a, int index)
        {
            r.N[0] = (uint)((int)a[index + 31] | (int)a[index + 30] << 8 | (int)a[index + 29] << 16 | ((int)a[index + 28] & 3) << 24);
            r.N[1] = (uint)((int)a[index + 28] >> 2 & 63 | (int)a[index + 27] << 6 | (int)a[index + 26] << 14 | ((int)a[index + 25] & 15) << 22);
            r.N[2] = (uint)((int)a[index + 25] >> 4 & 15 | (int)a[index + 24] << 4 | (int)a[index + 23] << 12 | ((int)a[index + 22] & 63) << 20);
            r.N[3] = (uint)((int)a[index + 22] >> 6 & 3 | (int)a[index + 21] << 2 | (int)a[index + 20] << 10 | (int)a[index + 19] << 18);
            r.N[4] = (uint)((int)a[index + 18] | (int)a[index + 17] << 8 | (int)a[index + 16] << 16 | ((int)a[index + 15] & 3) << 24);
            r.N[5] = (uint)((int)a[index + 15] >> 2 & 63 | (int)a[index + 14] << 6 | (int)a[index + 13] << 14 | ((int)a[index + 12] & 15) << 22);
            r.N[6] = (uint)((int)a[index + 12] >> 4 & 15 | (int)a[index + 11] << 4 | (int)a[index + 10] << 12 | ((int)a[index + 9] & 63) << 20);
            r.N[7] = (uint)((int)a[index + 9] >> 6 & 3 | (int)a[index + 8] << 2 | (int)a[index + 7] << 10 | (int)a[index + 6] << 18);
            r.N[8] = (uint)((int)a[index + 5] | (int)a[index + 4] << 8 | (int)a[index + 3] << 16 | ((int)a[index + 2] & 3) << 24);
            r.N[9] = (uint)((int)a[index + 2] >> 2 & 63 | (int)a[index + 1] << 6 | (int)a[index] << 14);
            return (int)r.N[9] != 4194303 || ((int)r.N[8] & (int)r.N[7] & (int)r.N[6] & (int)r.N[5] & (int)r.N[4] & (int)r.N[3] & (int)r.N[2]) != 67108863 || r.N[1] + 64U + (r.N[0] + 977U >> 26) <= 67108863U;
        }

        public static void GetB32(byte[] r, Fe a)
        {
            r[0] = (byte)(a.N[9] >> 14 & (uint)byte.MaxValue);
            r[1] = (byte)(a.N[9] >> 6 & (uint)byte.MaxValue);
            r[2] = (byte)(((int)a.N[9] & 63) << 2 | (int)(a.N[8] >> 24) & 3);
            r[3] = (byte)(a.N[8] >> 16 & (uint)byte.MaxValue);
            r[4] = (byte)(a.N[8] >> 8 & (uint)byte.MaxValue);
            r[5] = (byte)(a.N[8] & (uint)byte.MaxValue);
            r[6] = (byte)(a.N[7] >> 18 & (uint)byte.MaxValue);
            r[7] = (byte)(a.N[7] >> 10 & (uint)byte.MaxValue);
            r[8] = (byte)(a.N[7] >> 2 & (uint)byte.MaxValue);
            r[9] = (byte)(((int)a.N[7] & 3) << 6 | (int)(a.N[6] >> 20) & 63);
            r[10] = (byte)(a.N[6] >> 12 & (uint)byte.MaxValue);
            r[11] = (byte)(a.N[6] >> 4 & (uint)byte.MaxValue);
            r[12] = (byte)(((int)a.N[6] & 15) << 4 | (int)(a.N[5] >> 22) & 15);
            r[13] = (byte)(a.N[5] >> 14 & (uint)byte.MaxValue);
            r[14] = (byte)(a.N[5] >> 6 & (uint)byte.MaxValue);
            r[15] = (byte)(((int)a.N[5] & 63) << 2 | (int)(a.N[4] >> 24) & 3);
            r[16] = (byte)(a.N[4] >> 16 & (uint)byte.MaxValue);
            r[17] = (byte)(a.N[4] >> 8 & (uint)byte.MaxValue);
            r[18] = (byte)(a.N[4] & (uint)byte.MaxValue);
            r[19] = (byte)(a.N[3] >> 18 & (uint)byte.MaxValue);
            r[20] = (byte)(a.N[3] >> 10 & (uint)byte.MaxValue);
            r[21] = (byte)(a.N[3] >> 2 & (uint)byte.MaxValue);
            r[22] = (byte)(((int)a.N[3] & 3) << 6 | (int)(a.N[2] >> 20) & 63);
            r[23] = (byte)(a.N[2] >> 12 & (uint)byte.MaxValue);
            r[24] = (byte)(a.N[2] >> 4 & (uint)byte.MaxValue);
            r[25] = (byte)(((int)a.N[2] & 15) << 4 | (int)(a.N[1] >> 22) & 15);
            r[26] = (byte)(a.N[1] >> 14 & (uint)byte.MaxValue);
            r[27] = (byte)(a.N[1] >> 6 & (uint)byte.MaxValue);
            r[28] = (byte)(((int)a.N[1] & 63) << 2 | (int)(a.N[0] >> 24) & 3);
            r[29] = (byte)(a.N[0] >> 16 & (uint)byte.MaxValue);
            r[30] = (byte)(a.N[0] >> 8 & (uint)byte.MaxValue);
            r[31] = (byte)(a.N[0] & (uint)byte.MaxValue);
        }

        public static void GetB32(byte[] r, int index, Fe a)
        {
            r[index] = (byte)(a.N[9] >> 14 & (uint)byte.MaxValue);
            r[index + 1] = (byte)(a.N[9] >> 6 & (uint)byte.MaxValue);
            r[index + 2] = (byte)(((int)a.N[9] & 63) << 2 | (int)(a.N[8] >> 24) & 3);
            r[index + 3] = (byte)(a.N[8] >> 16 & (uint)byte.MaxValue);
            r[index + 4] = (byte)(a.N[8] >> 8 & (uint)byte.MaxValue);
            r[index + 5] = (byte)(a.N[8] & (uint)byte.MaxValue);
            r[index + 6] = (byte)(a.N[7] >> 18 & (uint)byte.MaxValue);
            r[index + 7] = (byte)(a.N[7] >> 10 & (uint)byte.MaxValue);
            r[index + 8] = (byte)(a.N[7] >> 2 & (uint)byte.MaxValue);
            r[index + 9] = (byte)(((int)a.N[7] & 3) << 6 | (int)(a.N[6] >> 20) & 63);
            r[index + 10] = (byte)(a.N[6] >> 12 & (uint)byte.MaxValue);
            r[index + 11] = (byte)(a.N[6] >> 4 & (uint)byte.MaxValue);
            r[index + 12] = (byte)(((int)a.N[6] & 15) << 4 | (int)(a.N[5] >> 22) & 15);
            r[index + 13] = (byte)(a.N[5] >> 14 & (uint)byte.MaxValue);
            r[index + 14] = (byte)(a.N[5] >> 6 & (uint)byte.MaxValue);
            r[index + 15] = (byte)(((int)a.N[5] & 63) << 2 | (int)(a.N[4] >> 24) & 3);
            r[index + 16] = (byte)(a.N[4] >> 16 & (uint)byte.MaxValue);
            r[index + 17] = (byte)(a.N[4] >> 8 & (uint)byte.MaxValue);
            r[index + 18] = (byte)(a.N[4] & (uint)byte.MaxValue);
            r[index + 19] = (byte)(a.N[3] >> 18 & (uint)byte.MaxValue);
            r[index + 20] = (byte)(a.N[3] >> 10 & (uint)byte.MaxValue);
            r[index + 21] = (byte)(a.N[3] >> 2 & (uint)byte.MaxValue);
            r[index + 22] = (byte)(((int)a.N[3] & 3) << 6 | (int)(a.N[2] >> 20) & 63);
            r[index + 23] = (byte)(a.N[2] >> 12 & (uint)byte.MaxValue);
            r[index + 24] = (byte)(a.N[2] >> 4 & (uint)byte.MaxValue);
            r[index + 25] = (byte)(((int)a.N[2] & 15) << 4 | (int)(a.N[1] >> 22) & 15);
            r[index + 26] = (byte)(a.N[1] >> 14 & (uint)byte.MaxValue);
            r[index + 27] = (byte)(a.N[1] >> 6 & (uint)byte.MaxValue);
            r[index + 28] = (byte)(((int)a.N[1] & 63) << 2 | (int)(a.N[0] >> 24) & 3);
            r[index + 29] = (byte)(a.N[0] >> 16 & (uint)byte.MaxValue);
            r[index + 30] = (byte)(a.N[0] >> 8 & (uint)byte.MaxValue);
            r[index + 31] = (byte)(a.N[0] & (uint)byte.MaxValue);
        }

        public static void Negate(Fe r, Fe a, uint m)
        {
            r.N[0] = (uint)(134215774 * ((int)m + 1)) - a.N[0];
            r.N[1] = (uint)(134217598 * ((int)m + 1)) - a.N[1];
            r.N[2] = (uint)(134217726 * ((int)m + 1)) - a.N[2];
            r.N[3] = (uint)(134217726 * ((int)m + 1)) - a.N[3];
            r.N[4] = (uint)(134217726 * ((int)m + 1)) - a.N[4];
            r.N[5] = (uint)(134217726 * ((int)m + 1)) - a.N[5];
            r.N[6] = (uint)(134217726 * ((int)m + 1)) - a.N[6];
            r.N[7] = (uint)(134217726 * ((int)m + 1)) - a.N[7];
            r.N[8] = (uint)(134217726 * ((int)m + 1)) - a.N[8];
            r.N[9] = (uint)(8388606 * ((int)m + 1)) - a.N[9];
        }

        public static void MulInt(Fe r, uint a)
        {
            r.N[0] *= a;
            r.N[1] *= a;
            r.N[2] *= a;
            r.N[3] *= a;
            r.N[4] *= a;
            r.N[5] *= a;
            r.N[6] *= a;
            r.N[7] *= a;
            r.N[8] *= a;
            r.N[9] *= a;
        }

        public static void Add(Fe r, Fe a)
        {
            r.N[0] += a.N[0];
            r.N[1] += a.N[1];
            r.N[2] += a.N[2];
            r.N[3] += a.N[3];
            r.N[4] += a.N[4];
            r.N[5] += a.N[5];
            r.N[6] += a.N[6];
            r.N[7] += a.N[7];
            r.N[8] += a.N[8];
            r.N[9] += a.N[9];
        }

        public static void MulInner(uint[] r, uint[] a, uint[] b)
        {
            var num1 = (ulong)((long)a[0] * (long)b[9] + (long)a[1] * (long)b[8] + (long)a[2] * (long)b[7] + (long)a[3] * (long)b[6] + (long)a[4] * (long)b[5] + (long)a[5] * (long)b[4] + (long)a[6] * (long)b[3] + (long)a[7] * (long)b[2] + (long)a[8] * (long)b[1] + (long)a[9] * (long)b[0]);
            var num2 = (uint)(num1 & 67108863UL);
            var num3 = num1 >> 26;
            var num4 = (ulong)a[0] * (ulong)b[0];
            var num5 = num3 + (ulong)((long)a[1] * (long)b[9] + (long)a[2] * (long)b[8] + (long)a[3] * (long)b[7] + (long)a[4] * (long)b[6] + (long)a[5] * (long)b[5] + (long)a[6] * (long)b[4] + (long)a[7] * (long)b[3] + (long)a[8] * (long)b[2] + (long)a[9] * (long)b[1]);
            var num6 = num5 & 67108863UL;
            var num7 = num5 >> 26;
            var num8 = num4 + num6 * 15632UL;
            var num9 = (uint)(num8 & 67108863UL);
            var num10 = (num8 >> 26) + num6 * 1024UL + (ulong)((long)a[0] * (long)b[1] + (long)a[1] * (long)b[0]);
            var num11 = num7 + (ulong)((long)a[2] * (long)b[9] + (long)a[3] * (long)b[8] + (long)a[4] * (long)b[7] + (long)a[5] * (long)b[6] + (long)a[6] * (long)b[5] + (long)a[7] * (long)b[4] + (long)a[8] * (long)b[3] + (long)a[9] * (long)b[2]);
            var num12 = num11 & 67108863UL;
            var num13 = num11 >> 26;
            var num14 = num10 + num12 * 15632UL;
            var num15 = (uint)(num14 & 67108863UL);
            var num16 = (num14 >> 26) + num12 * 1024UL + (ulong)((long)a[0] * (long)b[2] + (long)a[1] * (long)b[1] + (long)a[2] * (long)b[0]);
            var num17 = num13 + (ulong)((long)a[3] * (long)b[9] + (long)a[4] * (long)b[8] + (long)a[5] * (long)b[7] + (long)a[6] * (long)b[6] + (long)a[7] * (long)b[5] + (long)a[8] * (long)b[4] + (long)a[9] * (long)b[3]);
            var num18 = num17 & 67108863UL;
            var num19 = num17 >> 26;
            var num20 = num16 + num18 * 15632UL;
            var num21 = (uint)(num20 & 67108863UL);
            var num22 = (num20 >> 26) + num18 * 1024UL + (ulong)((long)a[0] * (long)b[3] + (long)a[1] * (long)b[2] + (long)a[2] * (long)b[1] + (long)a[3] * (long)b[0]);
            var num23 = num19 + (ulong)((long)a[4] * (long)b[9] + (long)a[5] * (long)b[8] + (long)a[6] * (long)b[7] + (long)a[7] * (long)b[6] + (long)a[8] * (long)b[5] + (long)a[9] * (long)b[4]);
            var num24 = num23 & 67108863UL;
            var num25 = num23 >> 26;
            var num26 = num22 + num24 * 15632UL;
            var num27 = (uint)(num26 & 67108863UL);
            var num28 = (num26 >> 26) + num24 * 1024UL + (ulong)((long)a[0] * (long)b[4] + (long)a[1] * (long)b[3] + (long)a[2] * (long)b[2] + (long)a[3] * (long)b[1] + (long)a[4] * (long)b[0]);
            var num29 = num25 + (ulong)((long)a[5] * (long)b[9] + (long)a[6] * (long)b[8] + (long)a[7] * (long)b[7] + (long)a[8] * (long)b[6] + (long)a[9] * (long)b[5]);
            var num30 = num29 & 67108863UL;
            var num31 = num29 >> 26;
            var num32 = num28 + num30 * 15632UL;
            var num33 = (uint)(num32 & 67108863UL);
            var num34 = (num32 >> 26) + num30 * 1024UL + (ulong)((long)a[0] * (long)b[5] + (long)a[1] * (long)b[4] + (long)a[2] * (long)b[3] + (long)a[3] * (long)b[2] + (long)a[4] * (long)b[1] + (long)a[5] * (long)b[0]);
            var num35 = num31 + (ulong)((long)a[6] * (long)b[9] + (long)a[7] * (long)b[8] + (long)a[8] * (long)b[7] + (long)a[9] * (long)b[6]);
            var num36 = num35 & 67108863UL;
            var num37 = num35 >> 26;
            var num38 = num34 + num36 * 15632UL;
            var num39 = (uint)(num38 & 67108863UL);
            var num40 = (num38 >> 26) + num36 * 1024UL + (ulong)((long)a[0] * (long)b[6] + (long)a[1] * (long)b[5] + (long)a[2] * (long)b[4] + (long)a[3] * (long)b[3] + (long)a[4] * (long)b[2] + (long)a[5] * (long)b[1] + (long)a[6] * (long)b[0]);
            var num41 = num37 + (ulong)((long)a[7] * (long)b[9] + (long)a[8] * (long)b[8] + (long)a[9] * (long)b[7]);
            var num42 = num41 & 67108863UL;
            var num43 = num41 >> 26;
            var num44 = num40 + num42 * 15632UL;
            var num45 = (uint)(num44 & 67108863UL);
            var num46 = (num44 >> 26) + num42 * 1024UL + (ulong)((long)a[0] * (long)b[7] + (long)a[1] * (long)b[6] + (long)a[2] * (long)b[5] + (long)a[3] * (long)b[4] + (long)a[4] * (long)b[3] + (long)a[5] * (long)b[2] + (long)a[6] * (long)b[1] + (long)a[7] * (long)b[0]);
            var num47 = num43 + (ulong)((long)a[8] * (long)b[9] + (long)a[9] * (long)b[8]);
            var num48 = num47 & 67108863UL;
            var num49 = num47 >> 26;
            var num50 = num46 + num48 * 15632UL;
            var num51 = (uint)(num50 & 67108863UL);
            var num52 = (num50 >> 26) + num48 * 1024UL + (ulong)((long)a[0] * (long)b[8] + (long)a[1] * (long)b[7] + (long)a[2] * (long)b[6] + (long)a[3] * (long)b[5] + (long)a[4] * (long)b[4] + (long)a[5] * (long)b[3] + (long)a[6] * (long)b[2] + (long)a[7] * (long)b[1] + (long)a[8] * (long)b[0]);
            var num53 = num49 + (ulong)a[9] * (ulong)b[9];
            var num54 = num53 & 67108863UL;
            var num55 = num53 >> 26;
            var num56 = num52 + num54 * 15632UL;
            r[3] = num27;
            r[4] = num33;
            r[5] = num39;
            r[6] = num45;
            r[7] = num51;
            r[8] = (uint)(num56 & 67108863UL);
            var num57 = (num56 >> 26) + num54 * 1024UL + (num55 * 15632UL + (ulong)num2);
            r[9] = (uint)(num57 & 4194303UL);
            var num58 = (num57 >> 22) + num55 * 16384UL;
            var num59 = num58 * 977UL + (ulong)num9;
            r[0] = (uint)(num59 & 67108863UL);
            var num60 = (num59 >> 26) + (num58 * 64UL + (ulong)num15);
            r[1] = (uint)(num60 & 67108863UL);
            var num61 = (num60 >> 26) + (ulong)num21;
            r[2] = (uint)num61;
        }

        public static void SqrInner(uint[] r, uint[] a)
        {
            var num1 = (ulong)((long)(a[0] * 2U) * (long)a[9] + (long)(a[1] * 2U) * (long)a[8] + (long)(a[2] * 2U) * (long)a[7] + (long)(a[3] * 2U) * (long)a[6] + (long)(a[4] * 2U) * (long)a[5]);
            var num2 = (uint)(num1 & 67108863UL);
            var num3 = num1 >> 26;
            var num4 = (ulong)a[0] * (ulong)a[0];
            var num5 = num3 + (ulong)((long)(a[1] * 2U) * (long)a[9] + (long)(a[2] * 2U) * (long)a[8] + (long)(a[3] * 2U) * (long)a[7] + (long)(a[4] * 2U) * (long)a[6] + (long)a[5] * (long)a[5]);
            var num6 = num5 & 67108863UL;
            var num7 = num5 >> 26;
            var num8 = num4 + num6 * 15632UL;
            var num9 = (uint)(num8 & 67108863UL);
            var num10 = (num8 >> 26) + num6 * 1024UL + (ulong)(a[0] * 2U) * (ulong)a[1];
            var num11 = num7 + (ulong)((long)(a[2] * 2U) * (long)a[9] + (long)(a[3] * 2U) * (long)a[8] + (long)(a[4] * 2U) * (long)a[7] + (long)(a[5] * 2U) * (long)a[6]);
            var num12 = num11 & 67108863UL;
            var num13 = num11 >> 26;
            var num14 = num10 + num12 * 15632UL;
            var num15 = (uint)(num14 & 67108863UL);
            var num16 = (num14 >> 26) + num12 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[2] + (long)a[1] * (long)a[1]);
            var num17 = num13 + (ulong)((long)(a[3] * 2U) * (long)a[9] + (long)(a[4] * 2U) * (long)a[8] + (long)(a[5] * 2U) * (long)a[7] + (long)a[6] * (long)a[6]);
            var num18 = num17 & 67108863UL;
            var num19 = num17 >> 26;
            var num20 = num16 + num18 * 15632UL;
            var num21 = (uint)(num20 & 67108863UL);
            var num22 = (num20 >> 26) + num18 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[3] + (long)(a[1] * 2U) * (long)a[2]);
            var num23 = num19 + (ulong)((long)(a[4] * 2U) * (long)a[9] + (long)(a[5] * 2U) * (long)a[8] + (long)(a[6] * 2U) * (long)a[7]);
            var num24 = num23 & 67108863UL;
            var num25 = num23 >> 26;
            var num26 = num22 + num24 * 15632UL;
            var num27 = (uint)(num26 & 67108863UL);
            var num28 = (num26 >> 26) + num24 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[4] + (long)(a[1] * 2U) * (long)a[3] + (long)a[2] * (long)a[2]);
            var num29 = num25 + (ulong)((long)(a[5] * 2U) * (long)a[9] + (long)(a[6] * 2U) * (long)a[8] + (long)a[7] * (long)a[7]);
            var num30 = num29 & 67108863UL;
            var num31 = num29 >> 26;
            var num32 = num28 + num30 * 15632UL;
            var num33 = (uint)(num32 & 67108863UL);
            var num34 = (num32 >> 26) + num30 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[5] + (long)(a[1] * 2U) * (long)a[4] + (long)(a[2] * 2U) * (long)a[3]);
            var num35 = num31 + (ulong)((long)(a[6] * 2U) * (long)a[9] + (long)(a[7] * 2U) * (long)a[8]);
            var num36 = num35 & 67108863UL;
            var num37 = num35 >> 26;
            var num38 = num34 + num36 * 15632UL;
            var num39 = (uint)(num38 & 67108863UL);
            var num40 = (num38 >> 26) + num36 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[6] + (long)(a[1] * 2U) * (long)a[5] + (long)(a[2] * 2U) * (long)a[4] + (long)a[3] * (long)a[3]);
            var num41 = num37 + (ulong)((long)(a[7] * 2U) * (long)a[9] + (long)a[8] * (long)a[8]);
            var num42 = num41 & 67108863UL;
            var num43 = num41 >> 26;
            var num44 = num40 + num42 * 15632UL;
            var num45 = (uint)(num44 & 67108863UL);
            var num46 = (num44 >> 26) + num42 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[7] + (long)(a[1] * 2U) * (long)a[6] + (long)(a[2] * 2U) * (long)a[5] + (long)(a[3] * 2U) * (long)a[4]);
            var num47 = num43 + (ulong)(a[8] * 2U) * (ulong)a[9];
            var num48 = num47 & 67108863UL;
            var num49 = num47 >> 26;
            var num50 = num46 + num48 * 15632UL;
            var num51 = (uint)(num50 & 67108863UL);
            var num52 = (num50 >> 26) + num48 * 1024UL + (ulong)((long)(a[0] * 2U) * (long)a[8] + (long)(a[1] * 2U) * (long)a[7] + (long)(a[2] * 2U) * (long)a[6] + (long)(a[3] * 2U) * (long)a[5] + (long)a[4] * (long)a[4]);
            var num53 = num49 + (ulong)a[9] * (ulong)a[9];
            var num54 = num53 & 67108863UL;
            var num55 = num53 >> 26;
            var num56 = num52 + num54 * 15632UL;
            r[3] = num27;
            r[4] = num33;
            r[5] = num39;
            r[6] = num45;
            r[7] = num51;
            r[8] = (uint)(num56 & 67108863UL);
            var num57 = (num56 >> 26) + num54 * 1024UL + (num55 * 15632UL + (ulong)num2);
            r[9] = (uint)(num57 & 4194303UL);
            var num58 = (num57 >> 22) + num55 * 16384UL;
            var num59 = num58 * 977UL + (ulong)num9;
            r[0] = (uint)(num59 & 67108863UL);
            var num60 = (num59 >> 26) + (num58 * 64UL + (ulong)num15);
            r[1] = (uint)(num60 & 67108863UL);
            var num61 = (num60 >> 26) + (ulong)num21;
            r[2] = (uint)num61;
        }

        public static void Mul(Fe r, Fe a, Fe b)
        {
            Field.MulInner(r.N, a.N, b.N);
        }

        public static void Sqr(Fe r, Fe a)
        {
            Field.SqrInner(r.N, a.N);
        }

        public static void Cmov(Fe r, Fe a, bool flag)
        {
            Field.Cmov(r, a, flag ? 1U : 0U);
        }

        public static void Cmov(Fe r, Fe a, uint flag)
        {
            var num1 = flag + uint.MaxValue;
            var num2 = ~num1;
            r.N[0] = (uint)((int)r.N[0] & (int)num1 | (int)a.N[0] & (int)num2);
            r.N[1] = (uint)((int)r.N[1] & (int)num1 | (int)a.N[1] & (int)num2);
            r.N[2] = (uint)((int)r.N[2] & (int)num1 | (int)a.N[2] & (int)num2);
            r.N[3] = (uint)((int)r.N[3] & (int)num1 | (int)a.N[3] & (int)num2);
            r.N[4] = (uint)((int)r.N[4] & (int)num1 | (int)a.N[4] & (int)num2);
            r.N[5] = (uint)((int)r.N[5] & (int)num1 | (int)a.N[5] & (int)num2);
            r.N[6] = (uint)((int)r.N[6] & (int)num1 | (int)a.N[6] & (int)num2);
            r.N[7] = (uint)((int)r.N[7] & (int)num1 | (int)a.N[7] & (int)num2);
            r.N[8] = (uint)((int)r.N[8] & (int)num1 | (int)a.N[8] & (int)num2);
            r.N[9] = (uint)((int)r.N[9] & (int)num1 | (int)a.N[9] & (int)num2);
        }

        public static void StorageCmov(FeStorage r, FeStorage a, bool flag)
        {
            var maxValue = uint.MaxValue;
            if (flag)
                ++maxValue;
            var num = ~maxValue;
            r.N[0] = (uint)((int)r.N[0] & (int)maxValue | (int)a.N[0] & (int)num);
            r.N[1] = (uint)((int)r.N[1] & (int)maxValue | (int)a.N[1] & (int)num);
            r.N[2] = (uint)((int)r.N[2] & (int)maxValue | (int)a.N[2] & (int)num);
            r.N[3] = (uint)((int)r.N[3] & (int)maxValue | (int)a.N[3] & (int)num);
            r.N[4] = (uint)((int)r.N[4] & (int)maxValue | (int)a.N[4] & (int)num);
            r.N[5] = (uint)((int)r.N[5] & (int)maxValue | (int)a.N[5] & (int)num);
            r.N[6] = (uint)((int)r.N[6] & (int)maxValue | (int)a.N[6] & (int)num);
            r.N[7] = (uint)((int)r.N[7] & (int)maxValue | (int)a.N[7] & (int)num);
        }

        public static void ToStorage(FeStorage r, Fe a)
        {
            r.N[0] = a.N[0] | a.N[1] << 26;
            r.N[1] = a.N[1] >> 6 | a.N[2] << 20;
            r.N[2] = a.N[2] >> 12 | a.N[3] << 14;
            r.N[3] = a.N[3] >> 18 | a.N[4] << 8;
            r.N[4] = (uint)((int)(a.N[4] >> 24) | (int)a.N[5] << 2 | (int)a.N[6] << 28);
            r.N[5] = a.N[6] >> 4 | a.N[7] << 22;
            r.N[6] = a.N[7] >> 10 | a.N[8] << 16;
            r.N[7] = a.N[8] >> 16 | a.N[9] << 10;
        }

        public static void FromStorage(Fe r, FeStorage a)
        {
            r.N[0] = a.N[0] & 67108863U;
            r.N[1] = a.N[0] >> 26 | (uint)((int)a.N[1] << 6 & 67108863);
            r.N[2] = a.N[1] >> 20 | (uint)((int)a.N[2] << 12 & 67108863);
            r.N[3] = a.N[2] >> 14 | (uint)((int)a.N[3] << 18 & 67108863);
            r.N[4] = a.N[3] >> 8 | (uint)((int)a.N[4] << 24 & 67108863);
            r.N[5] = a.N[4] >> 2 & 67108863U;
            r.N[6] = a.N[4] >> 28 | (uint)((int)a.N[5] << 4 & 67108863);
            r.N[7] = a.N[5] >> 22 | (uint)((int)a.N[6] << 10 & 67108863);
            r.N[8] = a.N[6] >> 16 | (uint)((int)a.N[7] << 16 & 67108863);
            r.N[9] = a.N[7] >> 10;
        }
    }
}

