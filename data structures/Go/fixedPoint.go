package main

//O(N)
//O(1)

func fixedPoint(arr []int) int {

	if len(arr) == 0 {
		return 0
	}

	for i := 0; i < len(arr); i++ {
		if arr[i] == i {
			return arr[i]
		}
	}
	return -1
}
