# ACE.Network
AC Network Stack

The AC Network stack as a library.
The goal is to generalize the network stack for both client and server applications, such that the same library can be used in the server, in tooling, and eventually in custom clients.

Data structures including Enums, Types, and Messages are documented in Messages.xml.
TemplateBuilder generates code based on Messages.xml into NetworkStack.
NetworkStack forms the core library for consumption by other applications for creating or reading AC network packets.
NetworkViewer is a utility to validate the data structures generated against retail PCAPs.

Currently able to defragment and parse messages from PCAPs.
As it stands (after removing invalid PCAPs) it successfully loads and parses all retail PCAPs in the 3 part ZIP repository.
This validates proper read length for all messages and types, but does not confirm proper parsing of individual variables.
