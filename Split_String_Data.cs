
#Repos of @YUDA, 3 June 2022
//================================================================================================================
// Your String Input must be = 111,111,111  "," will be splitted and convert data to variable, tested in C#  
//================================================================================================================
//Step 1 (if there is/are data of index is empty, data will be removed from index
//================================================================================================================
string _input = "111,111,111"
string[] splitted = _input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
string _data1 = splitted[0];
string _data2 = splitted[1];
string _data3 = splitted[2];

//================================================================================================================
//Step 2 (if there is/are data of index is empty, data will be null
//================================================================================================================
string _dataInput = "AA, ,55,66";
string[] inputParams = _dataInput.Split(',');
string Data1 = inputParams[0];
string Data2 = inputParams[1];
string Data3 = inputParams[2];
string Data4 = inputParams[3];

//================================================================================================================
//
//================================================================================================================
       
