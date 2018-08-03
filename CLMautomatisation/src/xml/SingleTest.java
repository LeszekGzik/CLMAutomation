package xml;

public class SingleTest {
	String testcase;
	String testdata;
	String name;

	public SingleTest(String testcase, String testdata, String name) {
		this.testcase = testcase;
		this.testdata = testdata;
		this.name = name;
	}
	
	public SingleTest() {
		
	}

	public void setCase(String testcase) {
		this.testcase = testcase;
	}
	
	public void setData(String testdata) {
		this.testdata = testdata;
	}
	
	public void setName(String name) {
		this.name = name;
	}
	
	public String getCase() {
		return testcase;
	}
	
	public String getData() {
		return testdata;
	}
	
	public String getName() {
		return name;
	}
}
