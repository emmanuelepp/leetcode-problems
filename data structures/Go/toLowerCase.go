package main

//O(N)
//O(1)
func toLowerCase(s string) string {

	if len(s) == 0 {
		return ""
	}

	result := ""

	for _, char := range s {
		if char >= 'A' && char <= 'Z' {
			char += 32
		}

		result += string(char)
	}

	return result
}
