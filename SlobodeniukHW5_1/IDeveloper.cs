using System;


namespace SlobodeniukHW5
{
    internal interface IDeveloper : IComparable<IDeveloper>
    {
        void Create();
        void Destroy();

        string Tool
        {
            get; set;
        }
    }
}
