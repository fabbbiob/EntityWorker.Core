using System;

namespace EntityWorker.SQLite
{
	public enum SQLiteChangeSetConflictType
	{
		Data = 1,
		NotFound = 2,
		Conflict = 3,
		Constraint = 4,
		ForeignKey = 5
	}
}