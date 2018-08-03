package xml;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.util.Iterator;
import java.util.Properties;

import javax.xml.stream.XMLEventReader;
import javax.xml.stream.XMLInputFactory;
import javax.xml.stream.XMLStreamException;
import javax.xml.stream.events.Attribute;
import javax.xml.stream.events.EndElement;
import javax.xml.stream.events.StartElement;
import javax.xml.stream.events.XMLEvent;

import testobjects.TestScenario;

public class XMLReadWriter {
	private FileInputStream in;
	
	public XMLReadWriter(String filePath) throws FileNotFoundException {
		in = new FileInputStream(filePath);
	}
	
	public XMLReadWriter(FileInputStream fis) {
		in = fis;
	}

	public TestScenario read(Properties globalProperties) throws XMLStreamException {
		TestScenario scenario = null;
		SingleTest test = null;
		TList tests = null;
		Iterator<Attribute> attributes;
		
        // First, create a new XMLInputFactory
        XMLInputFactory inputFactory = XMLInputFactory.newInstance();
        // Setup a new eventReader
        XMLEventReader eventReader = inputFactory.createXMLEventReader(in);
        // read the XML document
        

        while (eventReader.hasNext()) {
            XMLEvent event = eventReader.nextEvent();
            if (event.isStartElement()) {
                StartElement startElement = event.asStartElement();
                String local = startElement.getName().getLocalPart();
                switch(local) {
                case "scenario":
                	scenario = new TestScenario();
            		scenario.setProperties(globalProperties);
            		attributes = startElement.getAttributes();
                    while (attributes.hasNext()) {
                    	Attribute attribute = attributes.next();
                        if (attribute.getName().toString().equals("name")) {
                            scenario.setName(attribute.getValue());
                        }
                    }
                    break;
                case "tests":
                	tests = new TList();
                	break;
                case "test":
                	test = new SingleTest();
                    // We read the attributes from this tag and add the name attribute to our object
                    attributes = startElement.getAttributes();
                    while (attributes.hasNext()) {
                        Attribute attribute = attributes.next();
                        if (attribute.getName().toString().equals("name")) {
                            test.setName(attribute.getValue());
                        }
                        else if (attribute.getName().toString().equals("testcase")) {
                        	test.setCase(attribute.getValue());
                        }
                        else if (attribute.getName().toString().equals("testdata")) {
                        	test.setData(attribute.getValue());
                        }
                    }
                    break;
                case "screenfolder":
                	event = eventReader.nextEvent();
            		scenario.setProperty("screenfolder", event.asCharacters().getData());
            		break;
                case "xlsoutput":
            		event = eventReader.nextEvent();
            		scenario.setProperty("xlsoutput", event.asCharacters().getData());
            		break;
                case "xlssheet":
                	event = eventReader.nextEvent();
            		scenario.setProperty("xlssheet", event.asCharacters().getData());
            		break;
                case "maxrepetitions":
                	event = eventReader.nextEvent();
            		scenario.setProperty("maxrepetitions", event.asCharacters().getData());
            		break;
                case "waitforinput":
                	event = eventReader.nextEvent();
                	scenario.setProperty("waitforinput", event.asCharacters().getData());
                	break;
                case "reportinglevel":
                	event = eventReader.nextEvent();
                	scenario.setProperty("reportinglevel", event.asCharacters().getData());
                	break;
                case "screenshootinglevel":
                	event = eventReader.nextEvent();
                	scenario.setProperty("screenshootinglevel", event.asCharacters().getData());
                	break;
                case "logginglevel":
                	event = eventReader.nextEvent();
                	scenario.setProperty("logginglevel", event.asCharacters().getData());
                	break;
                }
            }

            if (event.isEndElement()) {
                EndElement endElement = event.asEndElement();
                if (endElement.getName().getLocalPart().equals("test")) {
                    tests.add(test);
                }
                else if (endElement.getName().getLocalPart().equals("scenario")) {
                    scenario.addTests(tests);
                }
            }
        }
		return scenario;
	}
}
