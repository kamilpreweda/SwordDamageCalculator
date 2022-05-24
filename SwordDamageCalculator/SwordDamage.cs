﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SwordDamagePrototype
{
    public class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;

        public int Roll;
        public decimal MagicMultiplier = 1M;
        public int FlamingDamage = 0;
        public int Damage;
        public void CalculateDamage()
        {
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;
            Debug.WriteLine($"Po wykonaniu CalculateDamage: {Damage} (rzut: {Roll})");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();
            Debug.WriteLine($"Po wykonaniu SetMagic: {Damage} (rzut: {Roll})");
        }

        public void SetFlaming(bool isFlaming)
        {
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
                FlamingDamage = FLAME_DAMAGE;
            }
            else
            {
                FlamingDamage = 0;
            }
            CalculateDamage();
            Debug.WriteLine($"Po wykonaniu SetFlaming: {Damage} (rzut: {Roll})");
        }
    }
}
