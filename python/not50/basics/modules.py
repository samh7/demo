import sys
if "C:\\'my python modules\'" not in sys.path:
    sys.path.append("C:\\j'my python modules'")

from test_module_conditional_statements import is_even, even_or_odd

print(is_even(11))