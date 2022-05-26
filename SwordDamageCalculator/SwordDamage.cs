using System;
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
        private decimal magicMultiplier = 1M;
        private int flamingDamage = 0;
        public int Damage;

        public int GetBaseDamage() { return BASE_DAMAGE; }
        public decimal GetMagicMultiplier() { return magicMultiplier; }
        public int GetFlamingDamage() { return flamingDamage; }

        private void CalculateDamage()
        {
            Damage = (int)(Roll * magicMultiplier) + BASE_DAMAGE + flamingDamage;
            Debug.WriteLine($"Po wykonaniu CalculateDamage: {Damage} (rzut: {Roll})");
        }

        public void SetMagic(bool isMagic)
        {
            if (isMagic)
            {
                magicMultiplier = 1.75M;
            }
            else
            {
                magicMultiplier = 1M;
            }
            CalculateDamage();
            Debug.WriteLine($"Po wykonaniu SetMagic: {Damage} (rzut: {Roll})");
        }

        public void SetFlaming(bool isFlaming)
        {
            if (isFlaming)
            {
                Damage += FLAME_DAMAGE;
                flamingDamage = FLAME_DAMAGE;
            }
            else
            {
                flamingDamage = 0;
            }
            CalculateDamage();
            Debug.WriteLine($"Po wykonaniu SetFlaming: {Damage} (rzut: {Roll})");
        }
    }
}
