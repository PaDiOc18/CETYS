//CoffeeMachineInterface.java

public interface CoffeeMachineInterface {
	public void chooseFirstSelection();
	public void chooseSecondSelection();
}

//OldCoffeeMachine.java

public class OldCoffeeMachine {
	public OldCoffeeMachine() {

	}
	public void selectA();
	public void selectB();
}

//CoffeeTouchscreenAdapter.java

public class CoffeeTouchscreenAdapter implements CoffeeMachineInterface {

	public OldCoffeeMachine OldVendingMachine = new OldCoffeeMachine();

	public void chooseFirstSelection(
		OldVendingMachine.selectA();
	);

	public void chooseSecondSelection(
		OldVendingMachine.selectB();
	);
}


