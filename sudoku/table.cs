using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku
{
    class table
    {
        public place[,] dan;
        public int number_of_child;
        public table father;
        public table[] ch;
        public int length;
        public bool is_result;
        public table()
        {
            dan = new place[9, 9];
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    dan[i, j] = new place();
            number_of_child = 0;
            length = 0;
            is_result = false;
        }
        public void difine_D()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dan[i, j].data < 1 && dan[i, j].data > 9)
                    {
                        if (i < 3)
                        {
                            if (j < 3)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                        }
                        if (i >= 3 && i < 6)
                        {
                            if (j < 3)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                        }
                        if (i >= 6 && i < 9)
                        {
                            if (j < 3)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp >= 1 && temp <= 9)
                                                dan[k, w].D[temp - 1] = 0;
                                        }
                                    }
                                }

                            }
                        }
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != j)
                            {
                                int temp = dan[i, k].data;
                                if (temp >= 1 && temp <= 9)
                                    dan[i, k].D[temp - 1] = 0;
                            }
                        }
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i)
                            {
                                int temp = dan[k, j].data;
                                if (temp >= 1 && temp <= 9)
                                    dan[k, j].D[temp - 1] = 0;
                            }
                        }
                    }
                }
            }
        }
        //////
        public bool table_is_result_1()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dan[i, j].data >= 1 && dan[i, j].data <= 9)
                    {
                        if (i < 3)
                        {
                            if (j < 3)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 0; k < 3; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                        }
                        if (i >= 3 && i < 6)
                        {
                            if (j < 3)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 3; k < 6; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                        }
                        if (i >= 6 && i < 9)
                        {
                            if (j < 3)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 0; w < 3; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 3 && j < 6)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 3; w < 6; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                            if (j >= 6 && j < 9)
                            {
                                for (int k = 6; k < 9; k++)
                                {
                                    for (int w = 6; w < 9; w++)
                                    {
                                        if (k != i && w != j)
                                        {
                                            int temp = dan[k, w].data;
                                            if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                                return false;
                                        }
                                    }
                                }

                            }
                        }
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != j)
                            {
                                int temp = dan[i, k].data;
                                if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                    return false;
                            }
                        }
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i)
                            {
                                int temp = dan[k, j].data;
                                if (temp < 1 || temp > 9 || temp == dan[i, j].data)
                                    return false;
                            }
                        }
                    }
                    else return false;
                }
            }
            return true;
        }
        public bool table_is_result()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    if (this.dan[i, j].data < 1 && this.dan[i, j].data > 9)
                        return false;
            }
            return true;
        }
        public bool way_is_false()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (this.dan[i, j].data < 1 && this.dan[i, j].data > 9)
                    {
                        int temp = 0;
                        for (int k = 0; k < 9; k++)
                            temp += this.dan[i, j].D[k];
                        if (temp == 0)
                            return true;
                    }
                }
            }
            return false;
        }
        public table copy_data()
        {
            table result = new table();
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    result.dan[i, j].data = this.dan[i, j].data;
            return result;
        }
        public int min_number_D()
        {
            int result = 9;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (dan[i, j].data < 1 || dan[i, j].data > 9)
                    {
                        int number = 0;
                        for (int k = 0; k < 9; k++)
                            if (dan[i, j].D[k] < 1 || dan[i, j].D[k] > 9)
                                number++;
                        if (number < result)
                            result = number;
                    }
                }
            }
            return result;
        }
        public int find_min_number_place(int min_number)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int place = 0;
                    for (int k = 0; k < 9; k++)
                    {
                        if (dan[i, j].D[k] != 0)
                            place++;
                    }
                    if (place == min_number)
                        return i * 10 + j;
                }
            }
            return 100;
        }
        public table solve()
        {
            table result = new table();
            result=this;
            Stack<table> stack1 = new Stack<table>();
            bool answer=true;
            while(answer)
            {
                result=stack1.Pop();
                result.difine_D();
                if(result.table_is_result_1())
                    answer=false;
                else
                {
                    if(!result.way_is_false())
                    {
                        int number=result.min_number_D();
                        int place_number=result.find_min_number_place(number);
                        int place_mumber_j=place_number%10;
                        int place_number_i=(place_number-place_mumber_j)/10;
                        result.ch=new table[number];
                        for(int i = 0,j=8;i<number;i++)
                        {
                            result.ch[i]=new table();
                            result.ch[i]=result.copy_data();
                            for(bool f=true;f && j>=0;j--)
                            {
                                if(result.dan[place_number_i,place_mumber_j].D[j]!=0)
                                {
                                    result.ch[i].dan[place_number_i,place_mumber_j].data=result.dan[place_number_i,place_mumber_j].D[j];
                                    f=false;
                                }
                            }
                            result.ch[i].father=result;
                            stack1.Push(result.ch[i]);
                        }
                    }
                    
                }
            }
            return result;

        }
    }
}
