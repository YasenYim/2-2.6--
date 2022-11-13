using System;
/*
 * 某些对象在整个系统中仅存在唯一的一个
 * 生活中，一个公司可能有很多员工，但是"总经理“只有一个
 * 一个游戏中，有很多角色，但是“角色管理器”只有一个，统筹管理所有的玩家和NPC角色
 * 通常的做法是使用“单例模式”。
 */

namespace _2_2._6_单例模板
{
    class ItemManager
    {
        private static ItemManager instance;
        public static ItemManager Instance
        {
            get
            {
                if(instance == null)
                { instance = new ItemManager(); }
                return instance;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
