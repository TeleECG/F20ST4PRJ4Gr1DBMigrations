﻿using System;
using System.Collections.Generic;

namespace F20ST4PRJ4Gr1SysModel
{
    public class PatientMeasurement // Patient klassen sendes i databasen med følgende: 
    {
        public PatientMeasurement() //Default constructor
        {
            ECGMeasurements = new List<ECGMeasurement>();
        }
        public PatientMeasurement(string cPRNumber, string name, string address)
        {
            ECGMeasurements = new List<ECGMeasurement>();
            CPRNumber = cPRNumber;
            Name = name;
            Address = address;
            Date = DateTime.Now;

            for (int i = 1; i < 4; i++)
            {
                ECGMeasurements.Add(new ECGMeasurement(i));
            }
        }

        public int PatientMeasurementId { get; set; } //Et autogenerede Id-nummer, der kun passer til den specifikke patient. 
        public string CPRNumber { get; set; } // CPR-nummer tilhørende patienten, som indtastes på brugergrænsefladen.
        public string Name { get; set; } // Navn tilhørende patienten, som indtastes på brugergrænsefladen.
        public string Address { get; set; } // Adresse tilhørende patienten, som indtastes på brugergrænsefladen.
        public DateTime Date { get; set; } // Autogenereret dato, der passer til tidspunktet dataen flyttes til databasen. 
        public List<ECGMeasurement> ECGMeasurements { get; } // En liste bestående af objekter af klassen ECGMeasurement.
    }

    public class ECGMeasurement // ECGMeasurement klassen sendes i databasen og kobles op med Patientobjektet med følgende: 
    {

        public ECGMeasurement()
        {
            ECGLeads = new List<ECGLead>();
        }
        public ECGMeasurement(int measurementNumber)
        {
            ECGLeads = new List<ECGLead>();
            MeasurementNumber = measurementNumber;
            for (int i = 1; i < 4; i++)
            {
                ECGLeads.Add(new ECGLead(i));
            }
        }

        public int ECGMeasurementId { get; set; } //Et autogenerede Id-nummer, der kun passer til den specifikke ECGMeasurement. 
        public PatientMeasurement PatientMeasurement { get; set; } //Objekt af Patient klassen
        public int PatientMeasurementId { get; set; } //Tilknytter ECGMeasurement til den specifikke Patient via PatientId
        public int MeasurementNumber { get; set; } // Et nummer der afgør om det er 1., 2., eller 3. måling
        public List<ECGLead> ECGLeads { get; set; } // En liste bestående af objekter af klassen ECGLead.
        public int Pulse { get; set; } // Patientens puls, som er udregnet ud fra den målte EKG data.
        public int HRV { get; set; } // Patientens HRV, som er udregnet ud fra den målte EKG data.
    }
    public class ECGLead // ECGMeasurement klassen sendes i databasen og kobles op med ECGMeasurementobjektet med følgende: 
    {
        public ECGLead(int leadNumber)
        {
            LeadNumber = leadNumber;
        }
        public int ECGLeadId { get; set; } //Et autogenerede Id-nummer, der kun passer til det specifikke ECGLead. 
        public ECGMeasurement ECGMeasurement { get; set; } //Objekt af ECGMeasurement klassen 
        public int ECGMeasurementId { get; set; } //Tilknytter ECGMeasurement til den specifikke ECGMeasurement via ECGMeasurementId
        public int LeadNumber { get; set; } // Et nummer der afgør om det er 1., 2., eller 3. afledning der i dette lead er målt
        public byte[] ECGLeadValues { get; set; } //Byte-array hvor ECG-værdier skal lægges i
    }


}
