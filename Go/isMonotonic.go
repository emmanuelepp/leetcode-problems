package main

func isMonotonic(nums []int) bool {

	if len(nums) == 0 {
		return false
	}

	increase := true
	decrese := true

	for i := 0; i < len(nums)-1; i++ {
		if nums[i] > nums[i+1] {
			increase = false
		}
		if nums[i] < nums[i+1] {
			decrese = false
		}
	}

	return increase || decrese
}
