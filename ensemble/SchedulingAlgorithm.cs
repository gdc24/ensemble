using System;

namespace ensemble {
    public class SchedulingAlgorithm {

        private string eventID;

        public SchedulingAlgorithm(string ID) {
            eventID = ID;
        }

        int numParts;
        numParts = *SQL stmt to find number of rehearsal parts*
        string[] rehearsalParts = new string[numParts];*loop to load rehearsal parts into array*

        int numRehearsals;
        numRehearsals= *SQL stmt to find number of rehearsals*
        string[] rehearsals = new string[numRehearsals];*loop to load rehearsals into array*


        public sort {

            for(int x = 0; x < numRehearsals; x++){

                int rLength;
                rLength = *SQL stmt to find end time* - *SQL stmt to find start time*;
            
                for(int i = 0; rLength > 0 & i < numParts; i++){
                    
                    if(rehearsalParts[i] != null){
                    
                    int numAvailable;
                    numAvailable = *SQL stmt to find number of members available during part i*;
                    string[] available = new string[numAvailable];*loop to load available members into array*;
                    
                    int numCalled;
                    numCalled= *SQL stmt to find number of members called to part*;
                    string[] called = new string[numCalled];*loop to load called members into array*;

                    int canAttend = 0;

                    for(int j = 0; j < numCalled; j++){
                        for(int k = 0; k < numAvailable; k++){
                            if(called[j] == available[k}){
                                canAttend++;
                                k = numAvailable;
                            }
                        }
                    }
                    
                    if(canAttend == numCalled){
                            *SQL stmt to assign part i to rehearsal x*
                            *SQL stmt to add members to callboard*
                            rehearsalParts[i] - null;
                    }
                }
            }
        }
    }
}