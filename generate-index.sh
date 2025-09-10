#!/bin/bash

# Define header and footer
HEADER=$(cat <<EOF
# Learn C# by Doing
Welcome to my hands-on C# learning journey. Each unit explores a different concept in .NET development, using pure console applications. No web frameworks. No distractions. Just clean, focused code.

## 📂 Units
EOF
)

FOOTER=$(cat <<EOF

## 🛠️ How to Run
Clone the repo and run any unit with:

\`\`\`bash
dotnet run --project ./01-hello-world
\`\`\`
EOF
)

# Generate dynamic unit list
UNIT_LIST=""
for dir in */ ; do
    if [ -f "$dir/README.md" ]; then
        UNIT_LIST+="- [${dir%/}](./${dir%/})"$'\n'
    fi
done

# Combine everything
echo "$HEADER" > README.md
echo "$UNIT_LIST" >> README.md
echo "$FOOTER" >> README.md
