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
            var tank = 0;            
            var startPoint = 0;
            var cont = 0;

            for (int i = startPoint; i < gas.Length && cont < gas.Length; i++)
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
    }
}
