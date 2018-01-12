package tpL2;

import tpL2.ClassArray;
import tpL2.ITransport;

public class ClassArray<T extends ITransport> {
	
	private T[] places;
	private T defaultValue;

	public ClassArray(int size, T defVal) {
		defaultValue = defVal;
		places = (T[]) new ITransport[size];
		for (int i = 0; i < places.length; i++) {
			places[i] = defaultValue;
		}
	}

	public T getObject(int ind) {
		if (ind > -1 && ind < places.length) {
			return places[ind];
		}
		return defaultValue;
	}

	public static <T extends ITransport> int plus(ClassArray<T> p, T plane) {
		for (int i = 0; i < p.places.length; i++) {
			if (p.CheckFreePlace(i)) {
				p.places[i] = plane;
				return i;
			}
		}
		return -1;
	}

	public static <T extends ITransport> T minus(ClassArray<T> p, int ind) {
		if (!p.CheckFreePlace(ind)) {
			T plane = p.places[ind];
			p.places[ind] = p.defaultValue;
			return plane;
		}
		return p.defaultValue;
	}

	public boolean CheckFreePlace(int index) {
		if (index < 0 || index > places.length) {
			return false;
		}
		if (places[index] == null) {
			return true;
		}
		if (places[index].equals(defaultValue)) {
			return true;
		}

		return false;
	}

}
