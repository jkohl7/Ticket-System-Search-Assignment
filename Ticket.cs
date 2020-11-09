using System;
using System.Collections.Generic;
using System.Text;

namespace TicketObject
{
    class Ticket
    {
    
        private string id, summ, status, prio, submit, assn, watch;


        public Ticket(string id, string summ, string status, string prio, string submit, string assn, string watch)
        {
            this.id = id;
            this.summ = summ;
            this.status = status;
            this.prio = prio;
            this.submit = submit;
            this.assn = assn;
            this.watch = watch;
        }

   

        public string getId()
        {
            return id;
        }

        public string getSumm()
        {
            return summ;
        }
        public string getStatus()
        {
            return status;
        }

        public string getPrio()
        {
            return prio;
        }

        public string getSubmit()
        {
            return submit;
        }

        public string getAssn()
        {
            return assn;
        }

        public string getWatch()
        {
            return watch;
        }


    }

}
