package main

func twoSum(nums []int, target int) []int {
	if len(nums) <= 0 {
		return []int{}
	}

	var dict = make(map[int]int)

	for i := 0; i < len(nums); i++ {
		var diff = target - nums[i]

		if _, ok := dict[diff]; ok {
			return []int{dict[diff], i}
		}

		dict[nums[i]] = i
	}
	return []int{}
}
