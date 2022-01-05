using chain_of_responsibility;

Car firstcheck = new FirstCheckup();
Car assemblicheck = new AssembliesCheck();
Car electriccheck = new ElectricCheck();
Car diagnosticcheck = new DiagnosticCheck();

firstcheck.setnext(assemblicheck);
assemblicheck.setnext(electriccheck);
electriccheck.setnext(diagnosticcheck);
diagnosticcheck.setnext(null);
firstcheck.Handle();