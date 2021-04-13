namespace ACM.BL
{
    public abstract class EntityBase
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }
        public bool IsNew { get; private set; }
        public bool HasChanges { get; set; }
        public bool IsValid => Validate();

        public EntityStateOption EntityState { get; set; }

        public abstract bool Validate();
        /*
        abstract method

        Method signature - no implementation
        only in use in abstract classes 
        must be overrideden by derived class
        */

        /* 
        virtual 
        method with default implementation
        use in abstract or concrete classes
        can optionally be overridden.
        */

    }
}