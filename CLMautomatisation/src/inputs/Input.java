package inputs;

import excel.*;

/** Abstrakcyjna klasa przechowuj¹ca informacjê o pojedynczej instrukcji (np. Button, GoTo itp.) */
public abstract class Input {
	public String name;
	public String xpath;
	public String type;
	public String step;
	protected static int waitForInput;
	
	public Input(Config config) {
		this.name = config.getName();
		this.type = config.getType();
		this.xpath = config.getXpath();
		this.step = config.getStep();
		this.continueStep = true;
	}
	
	public static void setInputWait(int miliseconds) {
		waitForInput = miliseconds;
	}
	
	/** Zmienna okreœlaj¹ca czy nale¿y kontynuowaæ wykonywanie kroku */
	public boolean continueStep;
	
	public void fill(PList testdata) throws Exception {
		
	}
}
