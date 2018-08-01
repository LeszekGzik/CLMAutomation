package inputs;

import java.awt.Robot;
import java.awt.Toolkit;
import java.awt.datatransfer.StringSelection;
import java.awt.event.KeyEvent;

import org.openqa.selenium.By;

import excel.Config;
import excel.PList;
import testobjects.TestObject;

/** Upload'uje plik w stosowne do tego miejsce. Xpath powinien wskazywaæ na przycisk otwieraj¹cy okno wyboru pliku, a name powinno zawieraæ œcie¿kê do pliku. Wymaga xpath i name. */
public class UploadFileInput extends Input {

	@Override
	public void fill(PList testdata) throws Exception {
		super.fill(testdata);
		
		String data;
		if (name.charAt(0)=='&') {
			data = TestObject.globaldata.get(name.substring(1));
		}
		else if (name.charAt(0)=='$') {
			data = name.substring(1);
		}
		else {
			data = testdata.get(name);
		}
		
		StringSelection ss = new StringSelection(data);
		Toolkit.getDefaultToolkit().getSystemClipboard().setContents(ss, null);
		
		driver.findElement(By.xpath(xpath)).click();
		
		Robot robot = new Robot();
		robot.keyPress(KeyEvent.VK_CONTROL);
		robot.keyPress(KeyEvent.VK_V);
		robot.keyRelease(KeyEvent.VK_V);
		robot.keyRelease(KeyEvent.VK_CONTROL);
		Thread.sleep(1000);
		robot.keyPress(KeyEvent.VK_ENTER);
		robot.keyRelease(KeyEvent.VK_ENTER);
	}
	
	public UploadFileInput(Config config, TestObject parent) {
		super(config, parent);
	}

}
