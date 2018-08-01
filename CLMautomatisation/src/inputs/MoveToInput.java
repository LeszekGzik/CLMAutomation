package inputs;

import org.openqa.selenium.By;
import org.openqa.selenium.interactions.Actions;
import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Przesuwa kursor nad wybrany element. Wymaga tylko Xpath. */
public class MoveToInput extends Input {
	
	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		Actions action = new Actions(driver);
		action
			.moveToElement(driver.findElement(By.xpath(xpath)))
			.perform();
		Thread.sleep(1000);
	}
	
	public MoveToInput(Config config, TestObject parent) {
		super(config, parent);
	}
}
