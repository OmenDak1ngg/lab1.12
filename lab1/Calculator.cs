using System;
using System.Collections.Generic;
using System.Linq;

namespace lab1
{
    internal class Calculator
    {
        public Dictionary<string, int> CalculateC(Buyer[] buyers, int combinationLength)
        {
            Dictionary<string, int> combinationsCounts = new Dictionary<string, int>();

            foreach (Buyer buyer in buyers)
            {
                Product[] buyerProducts = buyer.GetProductsCopy();

                List<Product[]> combinations = GetCombinations(buyerProducts, combinationLength);

                foreach (Product[] combo in combinations)
                {
                    string key = string.Join(" и ", combo.Select(p => p.Name));

                    if (combinationsCounts.ContainsKey(key))
                        combinationsCounts[key]++;
                    else
                        combinationsCounts[key] = 1;
                }
            }

            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"Расчет C{combinationLength}");

            foreach (string key in combinationsCounts.Keys)
            {
                Console.WriteLine($"{key} купили {combinationsCounts[key]} раз");
            }

            Console.WriteLine(new string('*', 20));

            return combinationsCounts;
        }

        private List<Product[]> GetCombinations(Product[] products, int length)
        {
            List<Product[]> result = new List<Product[]>();
            Combine(products, new Product[length], 0, 0, result);
            return result;
        }

        private void Combine(Product[] products, Product[] current, int start, int index, List<Product[]> result)
        {
            if (index == current.Length)
            {
                result.Add((Product[])current.Clone());
                return;
            }

            for (int i = start; i < products.Length; i++)
            {
                current[index] = products[i];
                Combine(products, current, i + 1, index + 1, result);
            }
        }

        public Dictionary<string, int> CalculateL(Dictionary<string, int> Ck, int min, int combinationLength)
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine($"Расчет L{combinationLength}");

            List<string> keysToRemove = new List<string>();

            foreach (string key in Ck.Keys)
            {
                if (Ck[key] < min)
                {
                    keysToRemove.Add(key);
                    Console.WriteLine($"{key} не проходит минимальную выборку({min})");
                }
            }

            foreach (string key in keysToRemove)
            {
                Ck.Remove(key);
            }

            foreach (string key in Ck.Keys)
            {
                Console.WriteLine($"{key} купили {Ck[key]} раз");
            }

            Console.WriteLine(new string('*', 20));

            return Ck;
        }
        public Dictionary<string, int> CalculateNextC(Dictionary<string, int> Lk, Buyer[] buyers, int currentLength)
        {
            int nextLength = currentLength + 1;
            return CalculateC(buyers, nextLength);
        }
    }
}