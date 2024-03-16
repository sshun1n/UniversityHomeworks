//#pragma once
//
//// main inclusions
//#include <iostream>
//#include <vector>
//#include <iomanip>
//
//using namespace std;
//
//vector<long int> _arrayInit(long int size) {
//	vector<long int> temp(size);
//	for (int i = 0; i < size; i++) temp[i] = rand() % 100 + 1;
//	return temp;
//}
//
//int _bubbleSort(vector<long int> array) {
//	int size = array.size(), counter = 0;
//
//	for (int i = 0; i < size - 1; i++) {
//		counter++;
//		for (int j = size - 1; j > i; j--) { 
//			counter++;
//			if (array[j] < array[j - 1]) { 
//				swap(array[j], array[j - 1]); counter++; 
//			} 
//		}
//	}
//
//	return counter;
//}
//
//int _sinkingSort(vector<long int> array) {
//	int size = array.size(), counter = 0;
//
//	for (int i = 0; i < size - 1; i++) {
//		counter++;
//		for (int j = size - 1; j > i; j--) { 
//			counter++;
//			if (array[j] < array[j - 1]) { 
//				swap(array[j], array[j - 1]); counter++;
//			} 
//		}
//	}
//
//	return counter;
//}
//
//int _qSinkingSort(vector<long int> arr) {
//	int size = arr.size(), i = 0, counter = 0; bool flag = true;
//
//	while (flag) {
//		flag = false; counter++;
//		for (int j = size - 1; j > i; j--) {
//			counter++;
//			if (arr[j] < arr[j - 1]) {
//				flag = true; counter++;
//				swap(arr[j], arr[j - 1]);
//			}
//		}
//		i++;
//	}
//
//	return counter;
//}
//
//int _shakerSort(vector<long int> array) {
//	bool flag = true; int size = array.size(), counter = 0, left = 0, right = size - 1;
//
//	while ((left < right) and flag) {
//		flag = false; counter++;
//
//		for (int i = left; i < right; i++) {
//			counter++;
//			if (array[i] > array[i + 1]) { flag = true; swap(array[i], array[i + 1]); counter++; }
//		} right--;
//
//		for (int j = right; j > left; j--) {
//			counter++;
//			if (array[j] < array[j - 1]) { flag = true; swap(array[j], array[j - 1]); counter++; }
//		} left++;
//	}
//
//	return counter;
//}
