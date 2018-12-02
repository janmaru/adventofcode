# Advent of Code 2018


## Given some static classes to load the data:
	  internal class Utility
	    {
	        private static string __DIR = Directory.GetCurrentDirectory();
	        public static IList<string> StringsFromInput(byte day)
	        {
	            return File.ReadAllLines(String.Format("{0}/days/{1}/input.txt", __DIR, day));
	        }
	
	        public static IList<Int32> IntsFromInput(byte day)
	        {
	            return Array.ConvertAll(File.ReadAllLines(String.Format("{0}/days/{1}/input.txt", __DIR, day)), int.Parse);
	        }
	    }

## First Day
### First Challenge
		public static int FirstChallenge()
		{
		    return Utility.IntsFromInput(1).Sum();
		}

### Second Challenge
        public static int SecondChallenge()
        {
            var frequencies = Utility.IntsFromInput(1);
            var f = new Dictionary<int, int>();
            var pre = 0;
            while (true)
            {
                for (int i = 0; i < frequencies.Count(); i++)
                {
                    pre += frequencies[i];

                    if (f.ContainsKey(pre))
                    {
                        return pre;
                    }
                    else
                    {
                        f.Add(pre, pre);
                    }
                }
            }
        }

## Second Day
### First Challenge

		public static int FirstChallenge()
		{
			var frequencies = Utility.StringsFromInput(2);
			var twos = 0;
			var threes = 0;
			
			foreach (string hash in frequencies)
			{
			    var characters = hash.ToCharArray().Distinct();
			    var isdue = false;
			    var istre = false;
			    foreach (var c in characters)
			    {
			        int count = hash.Split(c).Length - 1;
			        if (count == 2 && !isdue)
			        {
			            twos += 1;
			            isdue = true;
			        }
			        else if (count == 3 && !istre)
			        {
			            threes += 1;
			            istre = true;
			        }
			    }
			    isdue = false;
			    istre = false;
			}
			return twos * threes;
		}

### Second Challenge

            public static string SecondChallenge()
            {
                var frequencies = Utility.StringsFromInput(2);
                var count = 1;
                foreach (string item in frequencies)
                {
                    for (int i = count; i < frequencies.Count - 2; i++)
                    {
                        var cc = item.ToCharArray();
                        var ccount = 0;
                        for (int j = 0; j < cc.Length - 1; j++)
                        {
                            if (cc[j] != frequencies[i][j])
                            {
                                ccount += 1;
                            }
                        }
                        if (ccount == 1)
                        {
                            var result = string.Empty;
                            for (int k = 0; k < item.Length; k++)
                            {
                                if (item[k] == frequencies[i][k])
                                    result += item[k];
                            }
                            return result;
                        }
                    }
                    count += 1;
                }
                return string.Empty;
            }
        }