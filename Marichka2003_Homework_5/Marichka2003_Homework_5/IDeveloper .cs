using System;


namespace Marichka2003_Homework_5
{
    interface IDeveloper : IComparable<IDeveloper>
    {
        string Tool { get; set; }
        void Create();
        void Destroy();
    }
}
