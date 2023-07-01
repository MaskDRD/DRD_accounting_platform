using accounting_platform.utl;

namespace accounting_platform.model
{
    class StatusAttendanceModel: SelectModel
    {
        public StatusAttendanceModel(){}

        public StatusAttendanceModel(int id, string name ) {
            this.id = id;
            this.name = name;
        }

        public StatusAttendanceModel(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }
    }
}
