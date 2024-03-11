package main

//O(N)
//O(N)
func containsDuplicate(nums []int) bool {

	if len(nums) <= 0 {
		return false
	}

	var set = make(map[int]bool)

	for _, num := range nums {
		if set[num] {
			return true
		}
		set[num] = true
	}

	return false
}
