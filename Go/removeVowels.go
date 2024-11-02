package main

//O(N)
//O(1)
func removeVowels(s string) string {
	if len(s) == 0 {
		return ""
	}

	result := ""

	for _, char := range s {
		if char != 'a' && char != 'e' && char != 'i' && char != 'o' && char != 'u' {
			result += string(char)
		}
	}

	return result
}
