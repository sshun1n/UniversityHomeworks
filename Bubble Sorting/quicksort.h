#pragma once

// main inclusions
#include <iostream>
#include <vector>

using namespace std;

void myQuickSort(vector<int>& array, int start, int end) {
	int left = start, right = end, mid = (left + right) / 2;
	int pivot = array[mid];

	while (left <= right) {
		while (array[left] < pivot) left++;
		while (array[right] > pivot) right--;

		if (left <= right) {
			swap(array[left], array[right]);
			left++; right--;
		}
	}

	if (right > start) myQuickSort(array, start, right);
	if (left < end) myQuickSort(array, left, end);
}