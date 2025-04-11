using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._134._Gas_Station
{
    public class Solution
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Length == 1 && gas[0] >= cost[0])
            {
                return 0;
            }

            var tank = 0;
            var startPoint = FindStartPoint(gas, cost);
            var cont = 0;

            for (int i = startPoint; i < gas.Length && cont < gas.Length && startPoint > -1; i++)
            {
                var gasUnit = gas[i];
                var currentCost = cost[i];

                tank += gasUnit;
                if (tank < currentCost)
                {
                    tank = 0;
                    startPoint++;
                    i = startPoint - 1;
                    cont = 0;
                    if (startPoint >= gas.Length)
                    {
                        return -1;
                    }
                }
                else if (startPoint >= gas.Length)
                {
                    return -1;
                }
                else
                {
                    if (i == gas.Length - 1)
                    {
                        i = -1;
                    }
                    tank -= currentCost;
                    cont++;
                }
            }

            return startPoint;
        }

        private int FindStartPoint(int[] gas, int[] cost)
        {
            for (int i = 0; i < gas.Length; i++)
            {
                if (gas[i] - cost[i] > 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
