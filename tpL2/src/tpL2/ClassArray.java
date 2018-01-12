package tpL2;

import java.util.Dictionary;
import java.util.Hashtable;

import tpL2.ClassArray;
import tpL2.ITransport;

public class ClassArray<T extends ITransport> {
	
	
	private T defaultValue;
	private Dictionary<Integer, T> places;
	int maxCount;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}

	public T getObject(int ind) {
		if (places.get(ind)!=null) 
			return places.get(ind);
		
		return defaultValue;
	}

	public static <T extends ITransport> int plus(ClassArray<T> p, T plane) {
		if(p.places.size()==p.maxCount) return -1;
		for (int i = 0; i < p.places.size(); i++) {
			if (p.CheckFreePlace(i)) {
				p.places.put(i, plane);
				return i;
			}
		}
		p.places.put(p.places.size(), plane);
		return p.places.size()-1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int ind) {
		if (p.places.get(ind)!=null) {
			T plane = p.places.get(ind);
			p.places.remove(ind);
			return plane;
		}
		return p.defaultValue;
	}

	public boolean CheckFreePlace(int index) {
		if(places.get(index)==null){
			return true;
		}

		return false;
	}

}
