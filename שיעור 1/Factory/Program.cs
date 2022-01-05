using Factory;

IDietBase diet1 = DietFactory.GetDietnow(50, 190, 1.72);
IDietBase diet2 = DietFactory.GetDietnow(50, 69, 1.72);
IDietBase diet3 = DietFactory.GetDietnow(50, 110, 1.72);
IDietBase diet4 = DietFactory.GetDietnow(20, 100, 1.72);
diet1.GetDiet();
diet2.GetDiet();
diet3.GetDiet();
diet4.GetDiet();
